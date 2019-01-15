-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Jan 14. 18:44
-- Kiszolgáló verziója: 10.1.37-MariaDB
-- PHP verzió: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `gastro`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `besz`
--

CREATE TABLE `besz` (
  `azon` int(11) NOT NULL,
  `nev` varchar(30) COLLATE utf16_hungarian_ci NOT NULL,
  `cim` varchar(40) COLLATE utf16_hungarian_ci NOT NULL,
  `tel` int(10) NOT NULL,
  `email` varchar(40) COLLATE utf16_hungarian_ci NOT NULL,
  `kapcsnev` varchar(40) COLLATE utf16_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `helyek`
--

CREATE TABLE `helyek` (
  `IntAzon` int(11) NOT NULL,
  `irsz` int(4) NOT NULL,
  `varos` text NOT NULL,
  `utca` text NOT NULL,
  `szam` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- A tábla adatainak kiíratása `helyek`
--

INSERT INTO `helyek` (`IntAzon`, `irsz`, `varos`, `utca`, `szam`) VALUES
(1, 6666, 'Szeged', 'Kis', 45),
(1, 9999, 'Kübekháza', 'Nagy', 54),
(2, 7777, 'Miskolc', 'Csereszny', 30),
(2, 5555, 'Újszentiván', 'Kossuth', 70);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kat`
--

CREATE TABLE `kat` (
  `Tkatkod` int(11) NOT NULL,
  `Tnev` varchar(30) COLLATE utf16_hungarian_ci NOT NULL,
  `Tkatnev` varchar(20) COLLATE utf16_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `partnerek`
--

CREATE TABLE `partnerek` (
  `IntNev` text NOT NULL,
  `IntAzon` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- A tábla adatainak kiíratása `partnerek`
--

INSERT INTO `partnerek` (`IntNev`, `IntAzon`) VALUES
('elsovevo', 1),
('masodikvevo', 2);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szall`
--

CREATE TABLE `szall` (
  `azon` int(11) NOT NULL,
  `tkod` int(11) NOT NULL,
  `datum` date NOT NULL,
  `menny` int(11) NOT NULL,
  `ar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szamla`
--

CREATE TABLE `szamla` (
  `szamlaszam` int(50) NOT NULL,
  `datum` date NOT NULL,
  `Vkod` int(11) NOT NULL,
  `osszeg` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szamlatetel`
--

CREATE TABLE `szamlatetel` (
  `szamlaszam` int(50) NOT NULL,
  `Tkod` int(6) NOT NULL,
  `menny` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termekek`
--

CREATE TABLE `termekek` (
  `Tkod` int(11) NOT NULL,
  `Tnev` varchar(30) COLLATE utf16_hungarian_ci NOT NULL,
  `Tar` int(11) NOT NULL,
  `Tkeszl` int(11) NOT NULL,
  `Tmert` varchar(30) COLLATE utf16_hungarian_ci NOT NULL,
  `Tkatkod` int(11) NOT NULL,
  `Tvonkod` int(20) NOT NULL,
  `Tszavido` date NOT NULL,
  `Tegalizalte` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

--
-- A tábla adatainak kiíratása `termekek`
--

INSERT INTO `termekek` (`Tkod`, `Tnev`, `Tar`, `Tkeszl`, `Tmert`, `Tkatkod`, `Tvonkod`, `Tszavido`, `Tegalizalte`) VALUES
(1, 'kolbi', 300, 350, 'kg', 350, 132784678, '2018-02-03', 1),
(2, 'kolbika', 400, 450, 'kg', 2, 3456633, '2018-11-01', 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vevok`
--

CREATE TABLE `vevok` (
  `azon` int(11) NOT NULL,
  `nev` varchar(30) COLLATE utf16_hungarian_ci NOT NULL,
  `cim` varchar(30) COLLATE utf16_hungarian_ci NOT NULL,
  `tel` int(30) NOT NULL,
  `dolg` tinyint(1) NOT NULL,
  `torzs` tinyint(1) NOT NULL,
  `vasmenny` int(11) NOT NULL,
  `felh` varchar(30) COLLATE utf16_hungarian_ci NOT NULL,
  `jelsz` varchar(30) COLLATE utf16_hungarian_ci NOT NULL,
  `email` varchar(30) COLLATE utf16_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `besz`
--
ALTER TABLE `besz`
  ADD PRIMARY KEY (`azon`);

--
-- A tábla indexei `kat`
--
ALTER TABLE `kat`
  ADD PRIMARY KEY (`Tkatkod`);

--
-- A tábla indexei `partnerek`
--
ALTER TABLE `partnerek`
  ADD PRIMARY KEY (`IntAzon`);

--
-- A tábla indexei `szall`
--
ALTER TABLE `szall`
  ADD PRIMARY KEY (`azon`);

--
-- A tábla indexei `szamla`
--
ALTER TABLE `szamla`
  ADD PRIMARY KEY (`Vkod`);

--
-- A tábla indexei `szamlatetel`
--
ALTER TABLE `szamlatetel`
  ADD PRIMARY KEY (`szamlaszam`,`Tkod`);

--
-- A tábla indexei `termekek`
--
ALTER TABLE `termekek`
  ADD PRIMARY KEY (`Tkod`);

--
-- A tábla indexei `vevok`
--
ALTER TABLE `vevok`
  ADD PRIMARY KEY (`azon`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `besz`
--
ALTER TABLE `besz`
  MODIFY `azon` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `kat`
--
ALTER TABLE `kat`
  MODIFY `Tkatkod` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `szall`
--
ALTER TABLE `szall`
  MODIFY `azon` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `termekek`
--
ALTER TABLE `termekek`
  MODIFY `Tkod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `vevok`
--
ALTER TABLE `vevok`
  MODIFY `azon` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;