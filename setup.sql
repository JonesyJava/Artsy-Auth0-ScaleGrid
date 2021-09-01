CREATE TABLE IF NOT EXISTS artists(
  id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'create time',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'update time',
  name varchar(255) comment 'Artist Full Name',
  birthYear int NOT NULL COMMENT 'Year of Birth',
  deathYear int COMMENT 'Year of Death'
) default charset utf8 comment '';


CREATE TABLE IF NOT EXISTS pieces(
  id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'create time',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'update time',
  title varchar(255) comment 'Title',
  artistId int NOT NULL COMMENT 'FK: Artist',

  FOREIGN KEY (artistId) REFERENCES artists(id) ON DELETE CASCADE

) default charset utf8 comment '';

-- DROP TABLE IF EXISTS pieces;

-- INSERT INTO
--   artists(name, birthYear, deathYear)
-- VALUES("Michelangelo", 1475, 1564);
-- INSERT INTO
--   artists(name, birthYear, deathYear)
-- VALUES("Leonardo Da Vinci", 1452, 1519);
-- INSERT INTO
--   artists(name, birthYear, deathYear)
-- VALUES("Raphael Sanzio da Urbino", 1483, 1520);
-- INSERT INTO
--   artists(name, birthYear, deathYear)
-- VALUES("Leo", 1452, 1519);
-- -- GET ALL
-- SELECT
--   id,
--   name,
--   birthYear
-- FROM
--   artists;
-- -- ORDER BY birthYear DESC;
--   -- GET ONE BY ID
-- SELECT
--   *
-- FROM
--   artists
-- WHERE
--   id = 1;
-- UPDATE
--   artists
-- SET
--   name = "Leo"
-- WHERE
--   id = 2;

-- SELECT
--   *
-- FROM
--   artists
-- WHERE
--   birthYear < 1480;
-- -- DELETE FROM artists WHERE name = "Leo" AND birthYear < 1900;


-- INSERT INTO pieces (title, artistId)
-- VALUES ("The Last Judgment", 1);


-- SELECT 
--     p.*, 
--     a.name as "ArtistName" 
-- FROM pieces p
-- JOIN artists a ON a.id = p.artistId;