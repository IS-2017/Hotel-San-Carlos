-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 30-09-2016 a las 02:20:20
-- Versión del servidor: 10.1.16-MariaDB
-- Versión de PHP: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ejemplodll`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  `apellido` varchar(60) DEFAULT NULL,
  `descripcion` varchar(11) NOT NULL,
  `estado` varchar(45) NOT NULL DEFAULT 'ACTIVO',
  `Fecha` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`codigo`, `nombre`, `apellido`, `descripcion`, `estado`, `Fecha`) VALUES
(1, 'hola', 'adios', '0', 'INACTIVO', NULL),
(2, 'Andrea', 'c', '0', 'ACTIVO', NULL),
(3, 'b', 'c', '0', 'ACTIVO', NULL),
(4, 'b', 'c', '0', 'ACTIVO', NULL),
(5, NULL, NULL, '0', 'ACTIVO', NULL),
(6, NULL, NULL, '0', 'ACTIVO', NULL),
(7, 'Javier', 'Figueroa', '0', 'ACTIVO', NULL),
(8, 'Javier', 'Figueroa', '0', 'ACTIVO', NULL),
(9, 'Cristian', 'Estrada', '0', 'ACTIVO', NULL),
(10, 'nilson', 'reguan', '0', 'ACTIVO', NULL),
(11, 'Otto', 'hernandez', '0', 'ACTIVO', NULL),
(12, NULL, NULL, '0', 'ACTIVO', NULL),
(13, '1', 'perro', '0', 'ACTIVO', NULL),
(14, 'hola', 'arcilla', '0', 'ACTIVO', NULL),
(15, NULL, NULL, '0', 'ACTIVO', NULL),
(16, 'hola', 'herrera', '0', 'ACTIVO', NULL),
(17, 'Javier', 'sdasa', '0', 'ACTIVO', NULL),
(18, 'Hola', 'Nenas', '0', 'ACTIVO', NULL),
(19, 'hola', 'como ', '0', 'ACTIVO', NULL),
(20, 'manuel', 'que', '0', 'ACTIVO', NULL),
(21, 'hola', 'Hernandez', '0', 'ACTIVO', '2016-09-23'),
(22, 'Otto', 'Hernandez', '0', 'ACTIVO', NULL),
(23, 'Otto', 'Hernandez', '0', 'ACTIVO', NULL),
(24, 'andrea', 'Lopeza', '0', 'ACTIVO', NULL),
(25, 'hola', 'adios', '0', 'ACTIVO', NULL),
(26, 'Hola', 'como', '0', 'ACTIVO', NULL),
(27, 'hola', '24', '0', 'ACTIVO', NULL),
(28, 'hola', 'sdas', '0', 'ACTIVO', NULL),
(29, 'hola', '24', '0', 'ACTIVO', NULL),
(30, 'hola', 'raiz', '24', 'ACTIVO', NULL),
(31, 'hola', 'Hernandez', '0', 'ACTIVO', '2016-09-29');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`codigo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
