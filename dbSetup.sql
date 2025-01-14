-- Active: 1736871711556@@127.0.0.1@3306@adaptable_shaman_540684_db

-- adds table to database where we can store rows of data. usually your first step for a project
CREATE TABLE frogs(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name TINYTEXT NOT NULL,
  species ENUM('tree', 'toad', 'desert', 'goliath', 'regular') NOT NULL,
  size INT UNSIGNED NOT NULL,
  is_poisonous BOOLEAN NOT NULL DEFAULT false,
  bio TEXT NOT NULL
) DEFAULT CHARSET utf8mb4;

-- removes the entire table
DROP TABLE frogs;


-- inserts rows of data into table
INSERT INTO 
frogs(species, name, size, is_poisonous, bio)
VALUES
('desert', 'stinky', 10, false, "I eat garbage"),
('tree', 'marble', 4,true, "I eat flies and poison hikers"),
('tree', 'terry', 3,false, "I eat chili dogs"),
('regular', 'mick', 120,false, "I like long hops on the beach");

-- removes all rows from table 
DELETE FROM frogs;

-- removes a specific row from a table 
DELETE FROM frogs WHERE id = 1;

SELECT * FROM frogs;
SELECT * FROM frogs WHERE id = 6;
SELECT *, true AS hates_snakes FROM frogs WHERE size > 5;