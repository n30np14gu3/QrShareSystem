CREATE TABLE `requests` (
  `Id` int(11) NOT NULL,
  `ApplicantName` text NOT NULL,
  `ManagerName` text NOT NULL,
  `Address` text NOT NULL,
  `Topic` text NOT NULL,
  `Content` text NOT NULL,
  `Resolution` text NULL,
  `Status` smallint(6) NOT NULL DEFAULT 0,
  `Comment` text NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

