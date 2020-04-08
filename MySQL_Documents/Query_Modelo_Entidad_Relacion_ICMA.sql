-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema DBICMA
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema DBICMA
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `DBICMA` DEFAULT CHARACTER SET utf8 ;
USE `DBICMA` ;

-- -----------------------------------------------------
-- Table `DBICMA`.`Proveedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DBICMA`.`Proveedor` (
  `CodigoProveedor` INT NOT NULL AUTO_INCREMENT,
  `NombreProveedor` NVARCHAR(75) NOT NULL,
  `Direccion` NVARCHAR(125) NOT NULL,
  `Telefono` VARCHAR(9) NOT NULL,
  `TelefonoSecundario` VARCHAR(9) NULL,
  PRIMARY KEY (`CodigoProveedor`),
  UNIQUE INDEX `NombreProveedor_UNIQUE` (`NombreProveedor` ASC) VISIBLE,
  UNIQUE INDEX `Telefono_UNIQUE` (`Telefono` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DBICMA`.`TipoDeProducto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DBICMA`.`TipoDeProducto` (
  `CodigoTipoProducto` INT NOT NULL AUTO_INCREMENT,
  `TipoDeProducto` NVARCHAR(25) NOT NULL,
  PRIMARY KEY (`CodigoTipoProducto`),
  UNIQUE INDEX `CodigoTipoProducto_UNIQUE` (`CodigoTipoProducto` ASC) VISIBLE,
  UNIQUE INDEX `TipoDeProducto_UNIQUE` (`TipoDeProducto` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DBICMA`.`Producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DBICMA`.`Producto` (
  `CodigoProducto` INT NOT NULL AUTO_INCREMENT,
  `NombreProducto` NVARCHAR(50) NOT NULL,
  `Precio` INT NOT NULL,
  `Proveedor` INT NOT NULL,
  `Caracteristicas` NVARCHAR(200) NOT NULL,
  `TipoDeProducto` INT NOT NULL,
  PRIMARY KEY (`CodigoProducto`),
  INDEX `CodigoProveedor_idx` (`Proveedor` ASC) VISIBLE,
  INDEX `CodigoTipoProducto_idx` (`TipoDeProducto` ASC) VISIBLE,
  CONSTRAINT `CodigoProveedor`
    FOREIGN KEY (`Proveedor`)
    REFERENCES `DBICMA`.`Proveedor` (`CodigoProveedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `CodigoTipoProducto`
    FOREIGN KEY (`TipoDeProducto`)
    REFERENCES `DBICMA`.`TipoDeProducto` (`CodigoTipoProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DBICMA`.`Cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DBICMA`.`Cliente` (
  `CodigoCliente` INT NOT NULL AUTO_INCREMENT,
  `NombreCliente` NVARCHAR(125) NOT NULL,
  `TelefonoCliente` VARCHAR(9) NOT NULL DEFAULT '9999-9999',
  `TelefonoSecundarioCliente` VARCHAR(9) NULL,
  PRIMARY KEY (`CodigoCliente`),
  UNIQUE INDEX `TelefonoCliente_UNIQUE` (`TelefonoCliente` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DBICMA`.`Cotizacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DBICMA`.`Cotizacion` (
  `CodigoCotizacion` VARCHAR(7) NOT NULL,
  `DireccionDeAlmacenaje` NVARCHAR(150) NULL,
  `FechaDeCreacion` DATE NULL,
  `Cliente` INT NULL,
  PRIMARY KEY (`CodigoCotizacion`),
  INDEX `CodigoCliente_idx` (`Cliente` ASC) VISIBLE,
  CONSTRAINT `CodigoCliente`
    FOREIGN KEY (`Cliente`)
    REFERENCES `DBICMA`.`Cliente` (`CodigoCliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DBICMA`.`ProductoCotizacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DBICMA`.`ProductoCotizacion` (
  `CodigoProductoCotizacion` INT NOT NULL AUTO_INCREMENT,
  `CodigoCotizacion` VARCHAR(7) NOT NULL,
  `CodigoProducto` INT NOT NULL,
  PRIMARY KEY (`CodigoProductoCotizacion`),
  INDEX `CodigoProducto_idx` (`CodigoProducto` ASC) VISIBLE,
  INDEX `CodigoCotizacion_idx` (`CodigoCotizacion` ASC) VISIBLE,
  CONSTRAINT `CodigoProducto`
    FOREIGN KEY (`CodigoProducto`)
    REFERENCES `DBICMA`.`Producto` (`CodigoProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `CodigoCotizacion`
    FOREIGN KEY (`CodigoCotizacion`)
    REFERENCES `DBICMA`.`Cotizacion` (`CodigoCotizacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DBICMA`.`ProveedorCotizacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DBICMA`.`ProveedorCotizacion` (
  `CodigoProveedorCotizacion` INT NOT NULL AUTO_INCREMENT,
  `CodigoProveedor` INT NOT NULL,
  `CodigoCotizacion` VARCHAR(7) NOT NULL,
  PRIMARY KEY (`CodigoProveedorCotizacion`),
  INDEX `CodigoProveedor_idx` (`CodigoProveedor` ASC) VISIBLE,
  INDEX `CodigoCotizacion_idx` (`CodigoCotizacion` ASC) VISIBLE,
  CONSTRAINT `CodigoProveedor`
    FOREIGN KEY (`CodigoProveedor`)
    REFERENCES `DBICMA`.`Proveedor` (`CodigoProveedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `CodigoCotizacion`
    FOREIGN KEY (`CodigoCotizacion`)
    REFERENCES `DBICMA`.`Cotizacion` (`CodigoCotizacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
