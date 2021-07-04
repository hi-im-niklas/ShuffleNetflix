CREATE TABLE tUser
(
	UserID integer NOT NULL AUTO_INCREMENT,
    UserName varchar(40),
    Passwort varchar(40),
    Email varchar(40),
    Vorname varchar(40),
    Nachname varchar(80),
    PRIMARY KEY (UserID)
);

CREATE TABLE tSerie
(
	SerienID integer NOT NULL AUTO_INCREMENT,
    SerienName varchar(40),
    Beschreibung varchar(255),
    PRIMARY KEY (SerienID)
);

CREATE TABLE tEpisode
(
	EpisodeID integer NOT NULL AUTO_INCREMENT,
    EpiName varchar(40),
    Season integer,
    EpisodeNum integer,
    URL varchar(255),
    SerienID integer,
    PRIMARY KEY (EpisodeID),
    FOREIGN KEY (SerienID) REFERENCES tSerie(SerienID)
);
    
    