create database final

CREATE TABLE agents (
  id int NOT NULL,
  name varchar(255) NOT NULL,
  email varchar(255) DEFAULT NULL,
  phone varchar(20) DEFAULT NULL,
  address text DEFAULT NULL
)

--
-- Đang đổ dữ liệu cho bảng `agents`
--

INSERT INTO agents (id, name, email, phone, address) VALUES
(1, 'John Doe', 'johndoe@example.com', '+1 555-555-1234', '123 Main St'),
(2, 'Jane Smith', 'janesmith@example.com', '+1 555-555-5678', '456 Elm St'),
(3, 'Bob Johnson', 'bobjohnson@example.com', '+1 555-555-9012', '789 Oak St'),
(4, 'Sara Lee', 'saralee@example.com', '+1 555-555-3456', '321 Pine St'),
(5, 'Mike Williams', 'mikewilliams@example.com', '+1 555-555-7890', '654 Maple St'),
(6, 'Linda Brown', 'lindabrown@example.com', '+1 555-555-2345', '987 Cedar St'),
(7, 'Dave Wilson', 'davewilson@example.com', '+1 555-555-6789', '246 Oakwood Ave'),
(8, 'Karen Davis', 'karendavis@example.com', '+1 555-555-1234', '1356 Willow Rd'),
(9, 'Tom Johnson', 'tomjohnson@example.com', '+1 555-555-5678', '2468 Cedar Ave'),
(10, 'Cathy Martin', 'cathymartin@example.com', '+1 555-555-9012', '13579 Elmwood Dr'),
(11, 'Steve Baker', 'stevebaker@example.com', '+1 555-555-3456', '24680 Main St'),
(12, 'Debbie Jackson', 'debbiejackson@example.com', '+1 555-555-7890', '24680 Elm St'),
(13, 'Bill Clark', 'billclark@example.com', '+1 555-555-2345', '13579 Cedar St'),
(14, 'Susan Johnson', 'susanjohnson@example.com', '+1 555-555-6789', '2468 Willow Rd'),
(15, 'Joe Davis', 'joedavis@example.com', '+1 555-555-1234', '1357 Oakwood Ave'),
(16, 'Jenny Lee', 'jennylee@example.com', '+1 555-555-5678', '24680 Willow Dr'),
(17, 'Mark Jones', 'markjones@example.com', '+1 555-555-9012', '13579 Cedar Ave'),
(18, 'Lisa Green', 'lisagreen@example.com', '+1 555-555-3456', '2468 Maple St'),
(19, 'Mike Brown', 'mikebrown@example.com', '+1 555-555-7890', '1357 Elm St'),
(20, 'Julie Wilson', 'juliewilson@example.com', '+1 555-555-2345', '24680 Cedar St'),
(21, 'David Johnson', 'davidjohnson@example.com', '+1 555-555-6789', '13579 Main St'),
(22, 'Amy Martin', 'amymartin@example.com', '+1 555-555-1234', '2468 Oakwood Ave'),
(23, 'Robert Davis', 'robertdavis@example.com', '+1 555-555-5678', '1357 Willow Rd'),
(24, 'Emily Smith', 'emilysmith@example.com', '+1 555-555-9012', '24680 Elmwood Dr'),
(25, 'Greg Wilson', 'gregwilson@example.com', '+1 555-555-3456', '13579 Main St'),
(26, 'Tina Lee', 'tinalee@example.com', '+1 555-555-7890', '2468 Oakwood Ave'),
(27, 'Eric Johnson', 'ericjohnson@example.com', '+1 555-555-2345', '1357 Cedar St'),
(28, 'Mandy Martin', 'mandymartin@example.com', '+1 555-555-6789', '24680 Maple St'),
(29, 'Chris Davis', 'chrisdavis@example.com', '+1 555-555-1234', '13579 Elm St'),
(30, 'Rachel Green', 'rachelgreen@example.com', '+1 555-555-5678', '2468 Cedar Ave');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `category`
--

CREATE TABLE category (
  Category_ID int NOT NULL,
Category_Name varchar(255) NOT NULL,
  Category_Price int NOT NULL,
  Category_Quantity int NOT NULL
)

--
-- Đang đổ dữ liệu cho bảng `category`
--

INSERT INTO category (Category_ID, Category_Name, Category_Price, Category_Quantity) VALUES
(1, 'iPhone X', 1000, 7),
(2, 'Samsung Galaxy S10', 900, 27),
(3, 'Google Pixel 4', 800, 24),
(4, 'Huawei P30', 700, 35),
(5, 'Xiaomi Mi 9', 600, 40),
(6, 'OnePlus 7T', 650, 30),
(7, 'LG G8 ThinQ', 750, 25),
(8, 'Sony Xperia 1', 900, 20),
(9, 'Motorola Moto G7', 400, 50),
(10, 'Nokia 7.2', 350, 60),
(11, 'JBL Flip 5', 100, 65),
(12, 'Beats Solo3', 200, 40),
(13, 'Sony WH-1000XM3', 300, 30),
(14, 'Apple AirPods Pro',  250, 50),
(15, 'Samsung Galaxy Watch',  300, 15),
(16, 'Apple Watch Series 5',  400, 20),
(17, 'Fitbit Versa 2',  150, 70),
(18, 'Garmin Forerunner 945',  500, 15),
(19, 'GoPro HERO8 Black', 400, 30),
(20, 'DJI Mavic Air 2', 800, 10),
(21, 'HP Pavilion 15', 800, 15),
(22, 'Dell XPS 13',  1200, 10),
(23, 'Apple MacBook Air', 1000, 20),
(24, 'Lenovo ThinkPad X1 Carbon',  1500, 10),
(25, 'Samsung Galaxy Tab S6',  600, 10),
(26, 'Apple iPad Pro',  800, 20),
(27, 'Microsoft Surface Pro 7',  900, 14),
(28, 'Amazon Kindle Oasis', 250, 37),
(29, 'Canon EOS R',  2000, 2),
(30, 'Nikon D850', 3000, 0);

-- --------------------------------------------------------
select * from category
--

CREATE TABLE bill_xuat (
  billxuat_id varchar(255) NOT NULL,
	product_name varchar(255) NOT NULL,
  product_quantity int NOT NULL
)

select * from bill_xuat
-- Cấu trúc bảng cho bảng `form`
--

CREATE TABLE form (
  id varchar(255) NOT NULL,
  name varchar(255) NOT NULL,	
  quantity int NOT NULL,
) 

--
-- Đang đổ dữ liệu cho bảng `form`
--

insert into bill_xuat values ('phieu333', 'iphone', 33)

INSERT INTO form VALUES('phieu23', 'Huawei P30',  2);


-- --------------------------------------------------------
select * from form
--
-- Cấu trúc bảng cho bảng `orders`
--

CREATE TABLE orders (
  order_id int NOT NULL,
  agent_name varchar(50) NOT NULL,
  item_id int NOT NULL,
  item_name varchar(50) NOT NULL,
  item_des text NOT NULL,
  item_price float NOT NULL,
  payment_method varchar(50) NOT NULL,
  order_status varchar(50) NOT NULL,
  quantity int NOT NULL,
  email varchar(255) DEFAULT NULL
)

--
-- Đang đổ dữ liệu cho bảng `orders`
--

INSERT INTO orders (order_id, agent_name, item_id, item_name, item_des, item_price, payment_method, order_status, quantity, email) VALUES
(42, 'A', 3, 'Google Pixel 4', '', 800, 'cash', 'paid', 5, 'luongvietan.231123@gmail.com'),
(43, 'lập trình cơ sở', 2, 'Samsung Galaxy S10', '', 900, 'cash', 'paid', 1, 'l.v.a.2311@gmail.com'),
(44, 'java', 1, 'iPhone X', '', 1000, 'cash', 'paid', 3, 'luongvietan.231123@gmail.com'),
(45, 'lập trình cơ sở', 12, 'Beats Solo3', '', 200, 'transfer', 'pending', 1, 'luongvietan.231123@gmail.com');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `product`
--

CREATE TABLE product (
  Product_ID int NOT NULL,
  product_name varchar(255) NOT NULL,
  product_quantity int NOT NULL,
  category_id int NOT NULL
)

CREATE TABLE phieumua (
  tenkhachhang varchar(255) NOT NULL,
  maphieumua varchar(255) NOT NULl,
  product_name varchar(255) NOT NULL,
  product_quantity int NOT NULL
)
select * from phieumua
--
-- Đang đổ dữ liệu cho bảng `product`
--

INSERT INTO product (Product_ID, product_name, product_quantity, category_id) VALUES
(1, 'Product A1', 10, 1),
(2, 'Product A2', 5, 1),
(3, 'Product B1', 15, 2),
(7, 'An22', 1, 2),
(8, 'iPhone XSM', 5, 5),
(9, 'iPhone XS', 2, 4),
(10, 'iPhone XS', 2, 4),
(11, 'iPhone XS', 2, 4),
(12, 'iPhone XS', 2, 4);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `agents`
--
ALTER TABLE agents
  ADD PRIMARY KEY (id);

--
-- Chỉ mục cho bảng `category`
--
ALTER TABLE category
  ADD PRIMARY KEY (Category_ID);

--
-- Chỉ mục cho bảng `orders`
--
ALTER TABLE orders
  ADD PRIMARY KEY (order_id);

--
-- Chỉ mục cho bảng `product`
--
ALTER TABLE product
  ADD PRIMARY KEY (Product_ID),
  ADD KEY `Category_constraint` (`category_id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `category`
--
ALTER TABLE category
  MODIFY Category_ID int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT cho bảng `orders`
--
ALTER TABLE orders
  MODIFY order_id int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT cho bảng `product`
--
ALTER TABLE product
  MODIFY Product_ID int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `product`
--
ALTER TABLE product
  ADD CONSTRAINT Category_constraint FOREIGN KEY (category_id) REFERENCES category (Category_ID) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
