-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-10-2016 a las 04:30:26
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
-- Estructura de tabla para la tabla `consultaguardada`
--

CREATE TABLE `consultaguardada` (
  `idconsulta` int(11) NOT NULL,
  `idform` int(11) NOT NULL,
  `nombre` varchar(500) NOT NULL,
  `descripcion` varchar(500) NOT NULL,
  `tabla` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  `Fecha` date DEFAULT NULL,
  `Prueba` varchar(45) DEFAULT NULL,
  `prueba2` varchar(65) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`codigo`, `nombre`, `apellido`, `descripcion`, `estado`, `Fecha`, `Prueba`, `prueba2`) VALUES
(1, 'hola', 'adios', '0', 'INACTIVO', NULL, '', ''),
(2, 'Andrea', 'c', '0', 'INACTIVO', NULL, '', ''),
(3, 'hola', 'cristian', 'daniel', 'INACTIVO', '2016-10-19', 'prueba', ''),
(4, 'hola', '0', 'c', 'ACTIVO', '2016-10-19', 'Prueba', ''),
(5, NULL, NULL, '0', 'ACTIVO', NULL, '', ''),
(6, NULL, NULL, '0', 'ACTIVO', NULL, '', ''),
(7, 'Javier', 'Figueroa', '0', 'ACTIVO', NULL, '', ''),
(8, 'Javier', 'Figueroa', '0', 'ACTIVO', NULL, '', ''),
(9, 'Cristian', 'Estrada', '0', 'ACTIVO', NULL, '', ''),
(10, 'nilson', 'reguan', '0', 'ACTIVO', NULL, '', ''),
(11, 'Otto', 'hernandez', '0', 'ACTIVO', NULL, '', ''),
(12, NULL, NULL, '0', 'ACTIVO', NULL, '', ''),
(13, '1', 'perro', '0', 'ACTIVO', NULL, '', ''),
(14, 'hola', 'arcilla', '0', 'ACTIVO', NULL, '', ''),
(15, NULL, NULL, '0', 'ACTIVO', NULL, '', ''),
(16, 'hola', 'herrera', '0', 'ACTIVO', NULL, '', ''),
(17, 'Javier', 'sdasa', '0', 'ACTIVO', NULL, '', ''),
(18, 'Hola', 'Nenas', '0', 'ACTIVO', NULL, '', ''),
(19, 'hola', 'como ', '0', 'ACTIVO', NULL, '', ''),
(20, 'manuel', 'que', '0', 'ACTIVO', NULL, '', ''),
(21, 'hola', 'Hernandez', '0', 'ACTIVO', '2016-09-23', '', ''),
(22, 'Otto', 'Hernandez', '0', 'ACTIVO', NULL, '', ''),
(23, 'Otto', 'Hernandez', '0', 'ACTIVO', NULL, '', ''),
(24, 'andrea', 'Lopeza', '0', 'ACTIVO', NULL, '', ''),
(25, 'hola', 'adios', '0', 'ACTIVO', NULL, '', ''),
(26, 'Hola', 'como', '0', 'ACTIVO', NULL, '', ''),
(27, 'hola', '24', '0', 'ACTIVO', NULL, '', ''),
(28, 'hola', 'sdas', '0', 'ACTIVO', NULL, '', ''),
(29, 'hola', '24', '0', 'ACTIVO', NULL, '', ''),
(30, 'hola', 'raiz', '24', 'ACTIVO', NULL, '', ''),
(31, 'hola', 'Hernandez', '0', 'ACTIVO', '2016-09-29', 'hola', 'hola'),
(32, 'Otto', 'Hernandez', 'estudiante', 'ACTIVO', '2016-10-15', '', ''),
(33, NULL, NULL, '', 'ACTIVO', NULL, '', ''),
(34, 'Javier', 'Figueroa', 'Hola', 'ACTIVO', '2016-09-30', '', ''),
(35, 'Javier', 'Figueroa', 'Estudiante', 'ACTIVO', '2016-09-30', '', ''),
(36, 'Javier', 'Figueroa', 'Hlola', 'ACTIVO', '2016-09-09', '', ''),
(37, 'javier', 'hola', 'hola', 'ACTIVO', '2016-09-09', '', ''),
(38, 'asdas', 'adas', 'asdas', 'ACTIVO', '2016-09-02', '', ''),
(39, 'nilson', 'Hernandez', 'cccc', 'INACTIVO', '2016-03-03', '', ''),
(40, 'hola', 'safasd', 'asdasdas', 'ACTIVO', '2016-09-29', '', ''),
(41, 'hola', 'sadas', 'asdas', 'ACTIVO', '2016-10-07', '', ''),
(42, 'Andrea', 'asfa', 'adas', 'ACTIVO', '2016-10-13', '', ''),
(43, 'b', 'animal', 'holis', 'ACTIVO', '2016-10-06', '', ''),
(44, 'Cristian', 'cristian', 'marvin', 'ACTIVO', '2016-10-14', '', ''),
(45, 'b', 'chaca', 'grupo5', 'ACTIVO', '2016-10-06', '', ''),
(46, 'hola', 'dasda', 'asdas', 'ACTIVO', '2016-10-14', '', ''),
(47, 'Hola', 'Lopez', 'Hola', 'ACTIVO', '2016-10-13', '', ''),
(48, 'Javier', 'Figueroa', 'hola', 'ACTIVO', '2016-10-15', '', ''),
(49, 'Javier', 'javier', '0901132923', 'INACTIVO', '2016-10-05', '', ''),
(50, 'Otto', 'hernandez', 'hola', 'ACTIVO', '2016-10-08', '', ''),
(51, 'Hola', 'Reguan', 'Quisquinay', 'ACTIVO', '2016-10-19', 'Prueba', ''),
(52, 'Andrea', 'hasdasda', 'asdasda', 'INACTIVO', '2016-10-19', 'prueb', ''),
(53, 'hola', 'cristian', 'Figueroa', 'ACTIVO', '2016-10-19', 'prueba', ''),
(54, 'Javier', 'Figueroa ', 'Hola', 'ACTIVO', '2016-10-19', 'hola', ''),
(55, 'Javier', 'Figueroa ', 'Hola', 'ACTIVO', '2016-10-13', 'hola', 'hola'),
(56, 'Javier', 'Figueroa ', 'Hola', 'ACTIVO', '2016-10-19', 'hola', 'hola'),
(57, 'Otto', 'estrada', 'hola', 'ACTIVO', '2016-10-18', 'prueba5', '567'),
(58, 'hola', 'como', 'estas', 'ACTIVO', '2016-10-14', NULL, ''),
(59, 'hola', 'asxcas', 'asdas', 'ACTIVO', '2016-10-20', '121', '121');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `consultaguardada`
--
ALTER TABLE `consultaguardada`
  ADD PRIMARY KEY (`idconsulta`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`codigo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `consultaguardada`
--
ALTER TABLE `consultaguardada`
  MODIFY `idconsulta` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
