add-miggration cookie
update-database

-- SQLite
INSERT INTO Specialties (Name)
VALUES 
("Allergy and immunology"), 
("Anesthesiology"),
("Dermatology"),
("Diagnostic radiology"),
("Emergency medicine"),
("Family medicine"),
("Internal medicine"),
("Medical genetics"),
("Neurology"),
("Nuclear medicine"),
("Obstetrics and gynecology"),
("Ophthalmology"),
("Pathology"),
("Pediatrics"),
("Physical medicine and rehabilitation"),
("Preventive medicine"),
("Psychiatry"),
("Radiation oncology"),
("Surgery"),
("Urology");

INSERT INTO Cities (Name)
VALUES 
("Rio de Janeiro"), 
("Sao Paulo");


-- SQLite
CREATE TABLE AdvertisingBanners
(
BannerID BIGINT IDENTITY NOT NULL,
title VARCHAR(60) NOT NULL,
file VARCHAR(200) NOT NULL,
link VARCHAR(200) NULL,
PRIMARY KEY(BannerID)
);

-- SQLite
INSERT INTO AdvertisingBanners 
(BannerID, title, file, link)
VALUES
(1, 'Campanha Conio', 
'logo-conio-cademeumedico.png',
'http://conio.com.br');

INSERT INTO AdvertisingBanners
(BannerId, title, file, link) VALUES
(2,'Campanha Casa do Código', 
'banner-cdc-cademeumedico.png',
'http://casadocodigo.com.br')