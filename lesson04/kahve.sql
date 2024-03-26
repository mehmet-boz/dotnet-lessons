-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu sürümü:                5.7.36 - MySQL Community Server (GPL)
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- kahve için veritabanı yapısı dökülüyor
CREATE DATABASE IF NOT EXISTS `kahve` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_turkish_ci */;
USE `kahve`;

-- tablo yapısı dökülüyor kahve.anasayfa
CREATE TABLE IF NOT EXISTS `anasayfa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `foto` char(50) COLLATE utf8_turkish_ci NOT NULL,
  `ustBaslik` varchar(250) COLLATE utf8_turkish_ci NOT NULL,
  `ustIcerik` varchar(6000) COLLATE utf8_turkish_ci NOT NULL,
  `link` char(50) COLLATE utf8_turkish_ci NOT NULL,
  `altBaslik` char(250) COLLATE utf8_turkish_ci NOT NULL,
  `altIcerik` varchar(6000) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- kahve.anasayfa: 1 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `anasayfa` DISABLE KEYS */;
INSERT INTO `anasayfa` (`id`, `foto`, `ustBaslik`, `ustIcerik`, `link`, `altBaslik`, `altIcerik`) VALUES
	(1, 'intro.jpg', 'Değerli  İçecekler', '<p>12U Falan filan Every cup of our quality artisan coffee starts with locally sourced, hand picked ingredients. Once you try it, our coffee will be a blissful addition to your everyday morning routine - we guarantee it!</p>', 'To You', 'To You', '<p>When you walk into our shop to start your day, we are dedicated to providing you with friendly service, a welcoming atmosphere, and above all else, excellent products made with the highest quality ingredients. If you are not satisfied, please let us know and we will do whatever we can to make things right!</p>');
/*!40000 ALTER TABLE `anasayfa` ENABLE KEYS */;

-- tablo yapısı dökülüyor kahve.hakkimizda
CREATE TABLE IF NOT EXISTS `hakkimizda` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `foto` char(50) COLLATE utf8_turkish_ci NOT NULL,
  `ustBaslik` char(250) COLLATE utf8_turkish_ci NOT NULL,
  `baslik` char(250) COLLATE utf8_turkish_ci NOT NULL,
  `icerik` text COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- kahve.hakkimizda: 1 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `hakkimizda` DISABLE KEYS */;
INSERT INTO `hakkimizda` (`id`, `foto`, `ustBaslik`, `baslik`, `icerik`) VALUES
	(1, 'about.jpg', 'Strong Coffee, Strong Roots', 'Kafemiz Hakkında Bilgiler', '<p>Founded in 1987 by the Hernandez brothers, our establishment has been serving up rich coffee sourced from artisan farmers in various regions of South and Central America. We are dedicated to travelling the world, finding the best coffee, and bringing back to you here in our cafe.</p><p>We guarantee that you will fall in <i>lust</i> with our decadent blends the moment you walk inside until you finish your last sip. Join us for your daily routine, an outing with friends, or simply just to enjoy some alone time.</p><p><strong>Founded in 1987 by the Hernandez brothers, our establishment has been serving up rich coffee sourced from artisan farmers in various regions of South and Central America. We are dedicated to travelling the world, finding the best coffee, and bringing back to you here in our cafe.</strong></p><ol><li>We guarantee that you will fall in <i>lust</i> with our decadent blends the moment you walk inside until you finish your last sip. Join us for your daily routine, an outing with friends, or simply just to enjoy some alone time.</li><li>Founded in 1987 by the Hernandez brothers, our establishment has been serving up rich coffee sourced from artisan farmers in various regions of South and Central America. We are dedicated to travelling the world, finding the best coffee, and bringing back to you here in our cafe.</li><li>We guarantee that you will fall in <i>lust</i> with our decadent blends the moment you walk inside until you finish your last sip. Join us for your daily routine, an outing with friends, or simply just to enjoy some alone time.</li></ol>');
/*!40000 ALTER TABLE `hakkimizda` ENABLE KEYS */;

-- tablo yapısı dökülüyor kahve.iletisim
CREATE TABLE IF NOT EXISTS `iletisim` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ad` varchar(250) NOT NULL,
  `email` varchar(250) NOT NULL,
  `mesaj` text NOT NULL,
  `tarih` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;

-- kahve.iletisim: 3 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `iletisim` DISABLE KEYS */;
INSERT INTO `iletisim` (`id`, `ad`, `email`, `mesaj`, `tarih`) VALUES
	(23, 'aaa', 'aaa', 'aaaa', '2019-03-11 11:37:56'),
	(24, 'aaa', 'aaa', 'aaa', '2019-03-18 08:45:53'),
	(32, 'Deneme', 'deneme@a.com', 'falan filan', '2024-02-08 09:25:43');
/*!40000 ALTER TABLE `iletisim` ENABLE KEYS */;

-- tablo yapısı dökülüyor kahve.kullanicilar
CREATE TABLE IF NOT EXISTS `kullanicilar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kadi` char(50) NOT NULL,
  `parola` char(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- kahve.kullanicilar: 2 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `kullanicilar` DISABLE KEYS */;
INSERT INTO `kullanicilar` (`id`, `kadi`, `parola`) VALUES
	(1, 'admin', '105a9a2d46f64e147097c986076d2164'),
	(11, 'ali', '105a9a2d46f64e147097c986076d2164');
/*!40000 ALTER TABLE `kullanicilar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kahve.magaza
CREATE TABLE IF NOT EXISTS `magaza` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ustBaslik` char(50) NOT NULL DEFAULT '0',
  `anaBaslik` varchar(500) NOT NULL DEFAULT '0',
  `adres` char(250) NOT NULL DEFAULT '0',
  `telefon` char(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- kahve.magaza: 1 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `magaza` DISABLE KEYS */;
INSERT INTO `magaza` (`id`, `ustBaslik`, `anaBaslik`, `adres`, `telefon`) VALUES
	(1, 'COME ON IN', 'Çalışma Saatleri', '<p><i><strong>1116 Orchard Street</strong></i><br><i>Golden Valley, Minnesota&nbsp;</i></p>', '(317) 585-8468');
/*!40000 ALTER TABLE `magaza` ENABLE KEYS */;

-- tablo yapısı dökülüyor kahve.magazasaat
CREATE TABLE IF NOT EXISTS `magazasaat` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `gun` char(50) NOT NULL,
  `saat` char(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- kahve.magazasaat: 7 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `magazasaat` DISABLE KEYS */;
INSERT INTO `magazasaat` (`id`, `gun`, `saat`) VALUES
	(1, 'Pazartesi', '08:00 - 20:00'),
	(2, 'Salı', '08:00 - 20:00'),
	(3, 'Çarşamba', '08:00 - 20:00'),
	(4, 'Perşembe', '08:00 - 20:00'),
	(5, 'Cuma', '08:00 - 20:00'),
	(6, 'Cumartesi', 'Kapalı'),
	(7, 'Pazar', 'Kapalı');
/*!40000 ALTER TABLE `magazasaat` ENABLE KEYS */;

-- tablo yapısı dökülüyor kahve.urunler
CREATE TABLE IF NOT EXISTS `urunler` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `foto` char(50) COLLATE utf8_turkish_ci NOT NULL,
  `baslik` char(250) COLLATE utf8_turkish_ci NOT NULL,
  `ustBaslik` char(250) COLLATE utf8_turkish_ci NOT NULL,
  `icerik` text COLLATE utf8_turkish_ci NOT NULL,
  `aktif` tinyint(4) NOT NULL,
  `sira` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- kahve.urunler: 5 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `urunler` DISABLE KEYS */;
INSERT INTO `urunler` (`id`, `foto`, `baslik`, `ustBaslik`, `icerik`, `aktif`, `sira`) VALUES
	(4, 'products-01.jpg', 'Coffees Teas', 'Blended to Perfection', '<p class="mb-0">We take pride in our work, and it shows. Every time you order a beverage from us, we guarantee that it will be an experience worth having. Whether it\'s our world famous Venezuelan Cappuccino, a refreshing iced herbal tea, or something as simple as a cup of speciality sourced black coffee, you will be coming back for more.</p>', 1, 300),
	(3, 'products-03.jpg', 'Bulk Speciality Blends', 'From Around the World', '<p>Travelling the world for the very best quality coffee is something take pride in. When you visit us, you\'ll always find new blends from around the world, mainly from regions in Central and South America. We sell our blends in smaller to large bulk quantities. Please visit us in person for more details.</p>', 1, 50),
	(5, 'products-03.jpg', 'Bulk Speciality Blends', 'From Around the World', '<p class="mb-0">Travelling the world for the very best quality coffee is something take pride in. When you visit us, you\'ll always find new blends from around the world, mainly from regions in Central and South America. We sell our blends in smaller to large bulk quantities. Please visit us in person for more details.</p>', 1, 500),
	(6, 'products-02.jpg', 'Bakery', 'Delicious Treats, Good Eats', '<p class="mb-0">Our seasonal menu features delicious snacks, baked goods, and even full meals perfect for breakfast or lunchtime. We source our ingredients from local, oragnic farms whenever possible, alongside premium vendors for specialty goods.</p>', 1, 150),
	(7, 'products-02.jpg', 'Cakes', 'Delicios home made cakes', 'Demo içerik', 1, 200);
/*!40000 ALTER TABLE `urunler` ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
