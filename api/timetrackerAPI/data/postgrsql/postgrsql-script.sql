CREATE DATABASE timetracker;

-- Création de la table Activity
CREATE TABLE Activity (
    idActivity SERIAL PRIMARY KEY,
    nom TEXT NOT NULL,
    description TEXT
);

-- Création de la table TimePassed
CREATE TABLE TimePassed (
    idTimePassed SERIAL PRIMARY KEY,
    startHour INTEGER NOT NULL,
    endHour INTEGER NOT NULL,
    startMinute INTEGER NOT NULL,
    endMinute INTEGER NOT NULL,
    idActivity INTEGER NOT NULL,
    CONSTRAINT fk_activity FOREIGN KEY (idActivity) REFERENCES Activity (idActivity)
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