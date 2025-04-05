-- Create the database
--CREATE DATABASE Menu_Database2;
--GO

-- Switch to the new database
USE Menu_Database2;
GO

-- Create Dishes table
CREATE TABLE Dishes (
    DishId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255),
    ImageUrl VARCHAR(255),
    Price DECIMAL(10,2)
);
GO

-- Create Ingredients table
CREATE TABLE Ingredients (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100)
);
GO

-- Create DishIngredients table
CREATE TABLE DishIngredients (
    DishId INT,
    IngredientId INT,
    FOREIGN KEY (DishId) REFERENCES Dishes(DishId),
    FOREIGN KEY (IngredientId) REFERENCES Ingredients(Id)
);
GO

-- Insert data into Dishes
INSERT INTO Dishes (Name, ImageUrl, Price) VALUES
('Margherita Pizza', '/Images/margherita.jpeg', 250),
('Paneer Butter Masala', '/Images/paneer_butter_masala.jpeg', 320),
('Veg Biryani', '/Images/veg_biryani.jpeg', 280),
('Chicken Tikka', '/Images/chicken_tikka.jpeg', 350),
('Gulab Jamun', '/Images/gulab_jamun.jpeg', 120);
GO

-- Insert data into Ingredients
INSERT INTO Ingredients (Name) VALUES
('Cheese'),
('Cheese'),
('Rice'),
('Chicken'),
('Ghee'),
('Tomato sauce'),
('Oregano'),
('Tomato'),
('Vegetables'),
('Spices'),
('Yogurt'),
('Garlic'),
('Ginger'),
('Milk Powder'),
('Sugar');
GO

-- Insert data into DishIngredients
INSERT INTO DishIngredients (DishId, IngredientId) VALUES
(1, 1),
(2, 1),
(1, 2),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(1, 6),
(1, 7),
(2, 8),
(3, 9),
(3, 10),
(4, 10),
(3, 11),
(4, 11),
(4, 12),
(4, 13),
(5, 14),
(5, 15);
GO

