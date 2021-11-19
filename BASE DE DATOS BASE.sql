-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         8.0.25 - MySQL Community Server - GPL
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para zooapp
CREATE DATABASE IF NOT EXISTS `zooapp` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `zooapp`;

-- Volcando estructura para tabla zooapp.animales
CREATE TABLE IF NOT EXISTS `animales` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `jaula_id` int NOT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_animales_jaulas` (`jaula_id`),
  CONSTRAINT `FK_animales_jaulas` FOREIGN KEY (`jaula_id`) REFERENCES `jaulas` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Volcando datos para la tabla zooapp.animales: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `animales` DISABLE KEYS */;
INSERT INTO `animales` (`id`, `nombre`, `jaula_id`, `deleted_at`) VALUES
	(1, 'Caballo', 1, NULL),
	(2, 'Oso', 3, NULL),
	(3, 'Monos', 2, NULL);
/*!40000 ALTER TABLE `animales` ENABLE KEYS */;

-- Volcando estructura para tabla zooapp.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `documento` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `nombre` varchar(50) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`documento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Volcando datos para la tabla zooapp.clientes: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`documento`, `nombre`) VALUES
	('1221231', 'Juancho'),
	('31294518', 'Luis perez'),
	('51958452', 'Pedro arturo');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando estructura para tabla zooapp.espacios
CREATE TABLE IF NOT EXISTS `espacios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Volcando datos para la tabla zooapp.espacios: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `espacios` DISABLE KEYS */;
INSERT INTO `espacios` (`id`, `nombre`, `deleted_at`) VALUES
	(1, 'nuevo espacio', NULL),
	(2, 'fdsgfd', NULL),
	(3, 'prueba', NULL);
/*!40000 ALTER TABLE `espacios` ENABLE KEYS */;

-- Volcando estructura para tabla zooapp.jaulas
CREATE TABLE IF NOT EXISTS `jaulas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `espacio_id` int DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_Espacio_jaula` (`espacio_id`),
  CONSTRAINT `FK_Espacio_jaula` FOREIGN KEY (`espacio_id`) REFERENCES `espacios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Volcando datos para la tabla zooapp.jaulas: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `jaulas` DISABLE KEYS */;
INSERT INTO `jaulas` (`id`, `nombre`, `espacio_id`, `deleted_at`) VALUES
	(1, 'Jaula 1', 1, NULL),
	(2, 'Jaula 2', 2, NULL),
	(3, 'prueba 123', 2, NULL);
/*!40000 ALTER TABLE `jaulas` ENABLE KEYS */;

-- Volcando estructura para tabla zooapp.tickets
CREATE TABLE IF NOT EXISTS `tickets` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `valor` decimal(6,2) DEFAULT NULL,
  `cantidad_espacios` int DEFAULT '1',
  `deleted_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Volcando datos para la tabla zooapp.tickets: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tickets` DISABLE KEYS */;
INSERT INTO `tickets` (`id`, `nombre`, `valor`, `cantidad_espacios`, `deleted_at`) VALUES
	(1, 'N°1', 30.00, 4, NULL),
	(2, 'N°2', 50.00, 6, NULL),
	(3, 'N°3', 100.00, 10, NULL),
	(4, 'N°4', 250.00, -1, NULL);
/*!40000 ALTER TABLE `tickets` ENABLE KEYS */;

-- Volcando estructura para tabla zooapp.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL DEFAULT '0',
  `pass` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL DEFAULT '0',
  `nivel` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Volcando datos para la tabla zooapp.usuarios: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id`, `nombre`, `pass`, `nivel`) VALUES
	(1, 'mati', '123', 0),
	(2, 'vendedor', '123', 0),
	(3, 'admin', '123', -1);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- Volcando estructura para tabla zooapp.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `documento` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `ticket_id` int NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`documento`,`ticket_id`,`created_at`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Volcando datos para la tabla zooapp.ventas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` (`documento`, `ticket_id`, `created_at`) VALUES
	('1221231', 1, '2021-11-19 04:53:54'),
	('31294518', 3, '2021-11-19 04:39:20');
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
