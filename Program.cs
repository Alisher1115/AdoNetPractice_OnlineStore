/*
 * Создано в SharpDevelop.
 * Пользователь: Alisher
 * Дата: 11.12.2018
 * Время: 0:00
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineStore
{
	class Program
	{
		public static void Main(string[] args)
		{
            DataSet dataSet = new DataSet("OnlineStore");

            #region Customer
            DataTable customer = new DataTable("Customer");
            DataColumn customerId = new DataColumn("Id");
            customerId.DataType = typeof(int);
            customerId.AllowDBNull = false;
            customerId.AutoIncrement = true;
            customerId.AutoIncrementSeed = 1;
            customerId.AutoIncrementStep = 1;

            DataColumn customerFullName = new DataColumn("FullName");
            customerFullName.DataType = typeof(string);

            DataColumn customerAge = new DataColumn("Age");
            customerAge.DataType = typeof(int);

            DataColumn customerAddress = new DataColumn("Address");
            customerFullName.DataType = typeof(string);

            DataColumn customerPhone = new DataColumn("Phone");
            customerFullName.DataType = typeof(string);

            customer.Columns.Add(customerId);
            customer.Columns.Add(customerFullName);
            customer.Columns.Add(customerAge);
            customer.Columns.Add(customerAddress);
            customer.Columns.Add(customerPhone);

            // DataRow firstRow = customer.NewRow();

            // firstRow.BeginEdit();
            // firstRow.ItemArray = new object[] { 1, "P.P.Kirsanov", 42 };
            // firstRow.EndEdit();
            #endregion

            #region Employee
            DataTable employee = new DataTable("Employee");
            DataColumn employeeId = new DataColumn("Id");
            employeeId.DataType = typeof(int);
            employeeId.AllowDBNull = false;
            employeeId.AutoIncrement = true;
            employeeId.AutoIncrementSeed = 1;
            employeeId.AutoIncrementStep = 1;

            DataColumn employeeFullName = new DataColumn("FullName");
            employeeFullName.DataType = typeof(string);

            DataColumn employeeAge = new DataColumn("Age");
            employeeAge.DataType = typeof(int);

            DataColumn employeeAddress = new DataColumn("Address");
            employeeAddress.DataType = typeof(string);

            DataColumn employeePhone = new DataColumn("Phone");
            employeePhone.DataType = typeof(string);

            employee.Columns.Add(employeeId);
            employee.Columns.Add(employeeFullName);
            employee.Columns.Add(employeeAge);
            employee.Columns.Add(employeeAddress);
            employee.Columns.Add(employeePhone);
            #endregion

            #region Cart
            DataTable cart = new DataTable("Cart");
            DataColumn cartId = new DataColumn("Id");
            cartId.DataType = typeof(int);
            cartId.AllowDBNull = false;
            cartId.AutoIncrement = true;
            cartId.AutoIncrementSeed = 1;
            cartId.AutoIncrementStep = 1;

            DataColumn cartCustomerId = new DataColumn("CustomerId");
            cartFullName.DataType = typeof(int);

            DataColumn cartTotalSum = new DataColumn("TotalSum");
            cartAge.DataType = typeof(int);

            cart.Columns.Add(cartId);
            cart.Columns.Add(cartCustomerId);
            cart.Columns.Add(cartTotalSum);

            DataRelation cartCustomerIdRelation = new DataRelation("FK_cart_CustomerId", customerId, cartCustomerId);
            #endregion

            #region OrderStatus
            DataTable orderStatus = new DataTable("OrderStatus");
            DataColumn orderStatusId = new DataColumn("Id");
            orderStatusId.DataType = typeof(int);
            orderStatusId.AllowDBNull = false;
            orderStatusId.AutoIncrement = true;
            orderStatusId.AutoIncrementSeed = 1;
            orderStatusId.AutoIncrementStep = 1;

            DataColumn orderStatusName = new DataColumn("OrderStatusName");
            orderStatusName.DataType = typeof(string);

            orderStatus.Columns.Add(orderStatusId);
            orderStatus.Columns.Add(orderStatusName);
            #endregion
            
            #region Order
            DataTable order = new DataTable("Order");
            DataColumn orderId = new DataColumn("Id");
            orderId.DataType = typeof(int);
            orderId.AllowDBNull = false;
            orderId.AutoIncrement = true;
            orderId.AutoIncrementSeed = 1;
            orderId.AutoIncrementStep = 1;

            DataColumn orderCustomerId = new DataColumn("CustomerId");
            orderCustomerId.DataType = typeof(int);

            DataColumn orderEmployeeId = new DataColumn("EmployeeId");
            orderEmployeeId.DataType = typeof(int);

            DataColumn orderTotalSum = new DataColumn("TotalSum");
            orderTotalSum.DataType = typeof(int);

            DataColumn orderDate = new DataColumn("OrderDate");
            orderDate.DataType = typeof(DateTime);

            DataColumn orderOrderStatusId = new DataColumn("OrderStatusId");
            orderOrderStatusId.DataType = typeof(int);

            order.Columns.Add(orderId);
            order.Columns.Add(orderCustomerId);
            order.Columns.Add(orderEmployeeId);
            order.Columns.Add(orderTotalSum);
            order.Columns.Add(orderDate);
            order.Columns.Add(orderOrderStatusId);

            DataRelation orderCustomerIdRelation = new DataRelation("FK_order_CustomerId", customerId, orderCustomerId);
            DataRelation orderEmployeeIdRelation = new DataRelation("FK_order_EmployeeId", employeeId, orderEmployeeId);
            DataRelation orderOrderStatusIdRelation = new DataRelation("FK_order_orderStatusId", orderStatusId, orderOrderStatusId);
            #endregion

            #region DeliveryStatus
            DataTable deliveryStatus = new DataTable("DeliveryStatus");
            DataColumn deliveryStatusId = new DataColumn("Id");
            deliveryStatusId.DataType = typeof(int);
            deliveryStatusId.AllowDBNull = false;
            deliveryStatusId.AutoIncrement = true;
            deliveryStatusId.AutoIncrementSeed = 1;
            deliveryStatusId.AutoIncrementStep = 1;

            DataColumn deliveryStatusName = new DataColumn("deliveryStatusName");
            deliveryStatusName.DataType = typeof(string);

            deliveryStatus.Columns.Add(deliveryStatusId);
            deliveryStatus.Columns.Add(deliveryStatusName);
            #endregion
            
            #region Delivery
            DataTable delivery = new DataTable("Delivery");
            DataColumn deliveryId = new DataColumn("Id");
            deliveryId.DataType = typeof(int);
            deliveryId.AllowDBNull = false;
            deliveryId.AutoIncrement = true;
            deliveryId.AutoIncrementSeed = 1;
            deliveryId.AutoIncrementStep = 1;

            DataColumn deliveryOrderId = new DataColumn("OrderId");
            deliveryOrderId.DataType = typeof(int);

            DataColumn deliveryDeliveryStatusId = new DataColumn("DeliveryStatusId");
            deliveryDeliveryStatusId.DataType = typeof(int);

            delivery.Columns.Add(deliveryId);
            delivery.Columns.Add(deliveryOrderId);
            delivery.Columns.Add(deliveryDeliveryStatusId);

            DataRelation deliveryCustomerIdRelation = new DataRelation("FK_delivery_OrderId", orderId, deliveryOrderId);
            DataRelation deliveryDeliveryStatusIdRelation = new DataRelation("FK_delivery_StatusId", deliveryStatusId, deliveryDeliveryStatusId);
            #endregion

            #region Manufacturer
            DataTable manufacturer = new DataTable("Manufacturer");
            DataColumn manufacturerId = new DataColumn("Id");
            manufacturerId.DataType = typeof(int);
            manufacturerId.AllowDBNull = false;
            manufacturerId.AutoIncrement = true;
            manufacturerId.AutoIncrementSeed = 1;
            manufacturerId.AutoIncrementStep = 1;

            DataColumn manufacturerName = new DataColumn("Name");
            manufacturerName.DataType = typeof(string);

            manufacturer.Columns.Add(manufacturerId);
            manufacturer.Columns.Add(manufacturerName);
            #endregion
            
            #region Category
            DataTable category = new DataTable("Category");
            DataColumn categoryId = new DataColumn("Id");
            categoryId.DataType = typeof(int);
            categoryId.AllowDBNull = false;
            categoryId.AutoIncrement = true;
            categoryId.AutoIncrementSeed = 1;
            categoryId.AutoIncrementStep = 1;

            DataColumn categoryName = new DataColumn("Name");
            categoryName.DataType = typeof(string);

            category.Columns.Add(categoryId);
            category.Columns.Add(categoryName);
            #endregion
            
            #region Good
            DataTable good = new DataTable("Good");
            DataColumn goodId = new DataColumn("Id");
            goodId.DataType = typeof(int);
            goodId.AllowDBNull = false;
            goodId.AutoIncrement = true;
            goodId.AutoIncrementSeed = 1;
            goodId.AutoIncrementStep = 1;

            DataColumn goodName = new DataColumn("Name");
            goodName.DataType = typeof(string);

            DataColumn goodManufacturerId = new DataColumn("ManufacturerId");
            goodManufacturerId.DataType = typeof(int);

            DataColumn goodCategoryId = new DataColumn("CategoryId");
            goodCategoryId.DataType = typeof(int);

            DataColumn goodDescription = new DataColumn("Description");
            goodDescription.DataType = typeof(string);

            DataColumn goodPrice = new DataColumn("Price");
            goodPrice.DataType = typeof(int);

            good.Columns.Add(goodId);
            good.Columns.Add(goodName);
            good.Columns.Add(goodManufacturerId);
            good.Columns.Add(goodCategoryId);
            good.Columns.Add(goodDescription);
            good.Columns.Add(goodPrice);

            DataRelation goodManufacturerIdRelation = new DataRelation("FK_good_ManufacturerId", manufacturerId, goodManufacturerId);
            DataRelation goodCategoryIdRelation = new DataRelation("FK_good_CategoryId", categoryId, goodCategoryId);
            #endregion
            
            #region CartGood
            DataTable cartGood = new DataTable("CartGood");
            DataColumn cartGoodId = new DataColumn("Id");
            cartGoodId.DataType = typeof(int);
            cartGoodId.AllowDBNull = false;
            cartGoodId.AutoIncrement = true;
            cartGoodId.AutoIncrementSeed = 1;
            cartGoodId.AutoIncrementStep = 1;

            DataColumn cartGoodCartId = new DataColumn("CartId");
            cartGoodCartId.DataType = typeof(int);

            DataColumn cartGoodGoodId = new DataColumn("GoodId");
            cartGoodGoodId.DataType = typeof(int);

            DataColumn cartGoodGoodCount = new DataColumn("GoodCount");
            cartGoodGoodCount.DataType = typeof(int);

            cartGood.Columns.Add(cartGoodId);
            cartGood.Columns.Add(cartGoodCartId);
            cartGood.Columns.Add(cartGoodGoodId);
            cartGood.Columns.Add(cartGoodGoodCount);

            DataRelation cartGoodCartIdRelation = new DataRelation("FK_cartGood_CartId", cartId, cartGoodCartId);
            DataRelation cartGoodGoodIdRelation = new DataRelation("FK_cartGood_CartId", goodId, cartGoodGoodId);
            #endregion

            #region OrderGood
            DataTable orderGood = new DataTable("OrderGood");
            DataColumn orderGoodId = new DataColumn("Id");
            orderGoodId.DataType = typeof(int);
            orderGoodId.AllowDBNull = false;
            orderGoodId.AutoIncrement = true;
            orderGoodId.AutoIncrementSeed = 1;
            orderGoodId.AutoIncrementStep = 1;

            DataColumn orderGoodOrderId = new DataColumn("OrderId");
            orderGoodOrderId.DataType = typeof(int);

            DataColumn orderGoodGoodId = new DataColumn("GoodId");
            orderGoodGoodId.DataType = typeof(int);

            DataColumn orderGoodGoodCount = new DataColumn("GoodCount");
            orderGoodGoodCount.DataType = typeof(int);

            orderGood.Columns.Add(orderGoodId);
            orderGood.Columns.Add(orderGoodOrderId);
            orderGood.Columns.Add(orderGoodGoodId);
            orderGood.Columns.Add(orderGoodGoodCount);

            DataRelation orderGoodCartIdRelation = new DataRelation("FK_orderGood_CartId", orderId, orderGoodOrderId);
            DataRelation orderGoodGoodIdRelation = new DataRelation("FK_orderGood_CartId", goodId, orderGoodGoodId);
            #endregion
         
            #region TransactionStatus
            DataTable transactionStatus = new DataTable("TransactionStatus");
            DataColumn transactionStatusId = new DataColumn("Id");
            transactionStatusId.DataType = typeof(int);
            transactionStatusId.AllowDBNull = false;
            transactionStatusId.AutoIncrement = true;
            transactionStatusId.AutoIncrementSeed = 1;
            transactionStatusId.AutoIncrementStep = 1;

            DataColumn transactionStatusName = new DataColumn("transactionStatusName");
            transactionStatusName.DataType = typeof(string);

            transactionStatus.Columns.Add(transactionStatusId);
            transactionStatus.Columns.Add(transactionStatusName);
            #endregion
            
            #region Transaction
            DataTable transaction = new DataTable("Transaction");
            DataColumn transactionId = new DataColumn("Id");
            transactionId.DataType = typeof(int);
            transactionId.AllowDBNull = false;
            transactionId.AutoIncrement = true;
            transactionId.AutoIncrementSeed = 1;
            transactionId.AutoIncrementStep = 1;

            DataColumn transactionOrderId = new DataColumn("OrderId");
            transactionOrderId.DataType = typeof(int);

            DataColumn transactionTransactionStatusId = new DataColumn("TransactionStatusId");
            transactionTransactionStatusId.DataType = typeof(int);

            transaction.Columns.Add(transactionId);
            transaction.Columns.Add(transactionOrderId);
            transaction.Columns.Add(transactionTransactionStatusId);

            DataRelation transactionCustomerIdRelation = new DataRelation("FK_transaction_OrderId", orderId, transactionOrderId);
            DataRelation transactionTransactionStatusIdRelation = new DataRelation("FK_transaction_StatusId", transactionStatusId, transactionTransactionStatusId);
            #endregion

            dataSet.Tables.Add(customer);
            dataSet.Tables.Add(employee);
            dataSet.Tables.Add(cart);
            dataSet.Tables.Add(orderStatus);
            dataSet.Tables.Add(order);
            dataSet.Tables.Add(deliveryStatus);
            dataSet.Tables.Add(delivery);
            dataSet.Tables.Add(manufacturer);
            dataSet.Tables.Add(good);
            dataSet.Tables.Add(cartGood);
            dataSet.Tables.Add(orderGood);
            dataSet.Tables.Add(transactionStatus);
            dataSet.Tables.Add(transaction);
			Console.ReadKey(true);
		}
	}
}