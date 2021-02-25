Low Level Design

**Class Diagram**

**Classes:**

- Product: It list the available products
- User: Performs operations like add product to the cart, Placing Order, Bill payment
- Order: specifies the quantity of the product
- Payment:  it can be made in the form of cash and card
- Cart: Contains the products which the user added to it
- Category:  lists type of products
- Classes and their attributes:

**Attributes:**

- Product : Product\_id, Product\_type
- User: User\_id, User\_Name, Password, Mobile, Email, Address
- Order: Order\_id, Order\_Type, Customer\_id, Customer\_Name
- Cart: id, Price, Num\_of\_products
- Payment: id,Paid, Total
- Category: Type of product
