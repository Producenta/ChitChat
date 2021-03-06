/** Users table */
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) COLLATE utf8_bin NOT NULL,
  `password` char(32) COLLATE utf8_bin NOT NULL,
  `email` varchar(90) COLLATE utf8_bin NOT NULL,
  `joinDate` date NOT NULL,
  `ip` varchar(15) COLLATE utf8_bin NOT NULL,
  `info` tinytext COLLATE utf8_bin,
  `city` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `nation` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `phone` int(16) DEFAULT NULL,
  `sex` enum('Male','Female','Unknown') COLLATE utf8_bin NOT NULL DEFAULT 'Unknown',
  `name` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `isDonator` tinyint(1) NOT NULL,
  `onlineStance` enum('Online','Busy','AFK','Ghost','Offline') COLLATE utf8_bin NOT NULL DEFAULT 'Offline',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=8 ;

/** Contacts table */
CREATE TABLE IF NOT EXISTS `contacts` (
	`request_id` int(11) COLLATE utf8_bin NOT NULL AUTO_INCREMENT,
	`user_id` int(11) COLLATE utf8_bin NOT NULL,
	`friend_id` int(11) COLLATE utf8_bin NOT NULL,
	`accepted` tinyint(1) COLLATE utf8_bin NOT NULL DEFAULT 0,
	PRIMARY KEY(request_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;