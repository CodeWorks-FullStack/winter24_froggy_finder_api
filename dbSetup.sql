-- Active: 1736871711556@@127.0.0.1@3306@adaptable_shaman_540684_db
CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) UNIQUE COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';


CREATE TABLE frogs(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name TINYTEXT NOT NULL,
  species ENUM('tree', 'toad', 'desert', 'goliath', 'regular') NOT NULL,
  size INT UNSIGNED NOT NULL,
  is_poisonous BOOLEAN NOT NULL DEFAULT false
);

DROP TABLE frogs;