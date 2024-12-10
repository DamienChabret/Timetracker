Pour le moment, aucun appel API mais à terme il y aura un appel API. 
Interroge directement fichier sqlite.


Requête SQLITE : 
CREATE TABLE Activity (idActivity INTEGER PRIMARY KEY AUTOINCREMENT, nom TEXT, description TEXT); 

CREATE TABLE TimePassed (idTimePassed INTEGER PRIMARY KEY AUTOINCREMENT, startHour INTEGER, endHour INTEGER, startMinute INTEGER, endMinute INTEGER, idActivity INTEGER, FOREIGN KEY (idActivity) REFERENCES Activity(idActivity)); 

INSERT INTO Activity (nom, description) VALUES ('Escalade', 'Escalade en salle'), ('Courses', 'Courses en extérieur'), ('Gym', 'Séance de musculation'); 

INSERT INTO TimePassed (startHour, startMinute, endHour, endMinute, idActivity) VALUES (12, 3, 13, 0, 1), (9, 30, 10, 15, 1), (17, 0, 18, 15, 2), (15, 45, 16, 30, 2), (6, 15, 7, 0, 3), (18, 15, 19, 0, 3);

-- Création de la table Activity
CREATE TABLE Activity (
    idActivity INTEGER PRIMARY KEY AUTOINCREMENT,
    nom TEXT,
    description TEXT
);

-- Création de la table TimePassed
CREATE TABLE TimePassed (
    idTimePassed INTEGER PRIMARY KEY AUTOINCREMENT,
    startHour INTEGER,
    endHour INTEGER,
    startMinute INTEGER,
    endMinute INTEGER,
    idActivity INTEGER,
    FOREIGN KEY (idActivity) REFERENCES Activity(idActivity)
);

-- Insertion de fausses données dans la table Activity
INSERT INTO Activity (nom, description) VALUES 
    ('Escalade', 'Escalade en salle'),
    ('Courses', 'Courses en extérieur'),
    ('Gym', 'Séance de musculation');

-- Insertion de fausses données dans la table TimePassed
INSERT INTO TimePassed (startHour, startMinute, endHour, endMinute, idActivity) VALUES 
    (12, 3, 13, 0, 1),  -- Escalade de 12h03 à 13h00
    (9, 30, 10, 15, 1),  -- Escalade de 9h30 à 10h15
    (17, 0, 18, 15, 2),  -- Courses de 17h00 à 18h15
    (15, 45, 16, 30, 2),  -- Courses de 15h45 à 16h30
    (6, 15, 7, 0, 3),  -- Gym de 6h15 à 7h00
    (18, 15, 19, 0, 3);  -- Gym de 18h15 à 19h00
