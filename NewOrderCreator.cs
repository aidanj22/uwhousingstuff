using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWAdventure.Data;
using UWAdventure.Entities.DTO;
using UWAdventure.Entities.Persistence;
using UWAdventure.Enum;
using UWAdventure.Events;

namespace UWAdventure.BLL
{
    /// <summary>
    /// Business object responsible for creating new orders in the system
    /// </summary>
    public class NewOrderCreator
    {
        private readonly OrderDAO _orderDAO;
        private readonly OrderItemDAO _orderItemDAO;
        private readonly InventoryService _inventoryService;
        private readonly ProductService _productService;
        private readonly NewOrderProcessor _newOrderProcessor;
        private readonly NewOrderCreationNotificationService _newOrderNotifier;

        public event EventHandler<OrderCreatedEventArgs> OrderCreated;              //event delegate for when order is created

        public NewOrderCreator()
        {
            _inventoryService = new InventoryService();
            _orderDAO = new OrderDAO();
            _orderItemDAO = new OrderItemDAO();
            _productService = new ProductService();
            _newOrderNotifier = new NewOrderCreationNotificationService(this);
            _newOrderProcessor = new NewOrderProcessor(this);

        }

        /// <summary>
        /// Creates a new order
        /// </summary>
        /// <param name="orderDTO">information needed to create a new order</param>
        /// <returns>The newly created order's order number</returns>
        public int CreateOrder(NewOrderDTO newOrderDTO)
        {

            // this method is used to validate incoming data - NEVER TRUST DATA COMING FROM A UI

            int order_number = -1;

            // although we list the price of items in the UI, we never assume that the price being passed in is correct.
            // we only pass in the product id, and then we lookup the price to ensure its accuracy

            // create the orderDTO for persistence and populate its properties
            OrderDTO orderDTO = new OrderDTO()
            {
                customer_id = newOrderDTO.customer_id,
                order_date = newOrderDTO.order_date,
                staff_id = newOrderDTO.staff_id,
                store_id = newOrderDTO.store_id,
            };

            // now we'll use a method to get the order status
            // a method is the preferred way, as maybe there is some business
            // logic to determine was a new order's status is based on certain parameters
            orderDTO.order_status = (int)GetNewOrderStatus();


            //save to the persistence store, and get the order number back?
            order_number = _orderDAO.CreateOrder(orderDTO);

            // this is an unfortunate step - having to put the order_number into the DTO.  It's a little bit of data logic leaking into the 
            // business logic.  But it unfortunately is necessary when not using an advanced framework for persistence
            orderDTO.order_number = order_number;

            // now to populate items
            OrderItemDTO orderItemDTO;
            IList<OrderItemDTO> items = new List<OrderItemDTO>();
            foreach (NewOrderItemDTO item in newOrderDTO.items)
            {
                var product = _productService.GetByID(item.product_id);
                orderItemDTO = new OrderItemDTO()
                {
                    product_id = item.product_id,
                    price = product.list_price,
                    quantity = item.quantity,
                    order_number = order_number
                };

                items.Add(orderItemDTO);
            }

            //now save the items to the persistence store
            _orderItemDAO.CreateOrder(items);

            OnOrderCreated(orderDTO, items);


            return order_number;
        }


        /// <summary>
        /// Returns the status for a new order
        /// </summary>
        private OrderStatus GetNewOrderStatus()
        {
            //could have some additional logic where an order proceeds directly to processing or something.  For now, just use "Pending"
            return OrderStatus.Pending;
        }

        /// <summary>
        /// Trigger method called to raise the <see cref="OrderCreated"/> event
        /// </summary>
        protected virtual void OnOrderCreated(OrderDTO orderDTO, ICollection<OrderItemDTO> items)
        {
            //null test, without making a copy while keeping thread-safety
            OrderCreatedEventArgs args = new OrderCreatedEventArgs() { Order = orderDTO, Items = items };
            OrderCreated?.Invoke(this, args);
        }
    }
}
