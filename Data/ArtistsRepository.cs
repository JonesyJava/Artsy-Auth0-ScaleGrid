using System.Collections.Generic;
using System.Data;
using System.Linq;
using Artsy.Models;
using Dapper;

namespace Artsy.Data
{
    public class ArtistsRepository
    {
        private readonly IDbConnection _db;
        // SOLI(D) PRINCIPLE 
        //                       vvv DI (dependency injection)
        public ArtistsRepository(IDbConnection db)
        {
            _db = db;
        }

        public List<Artist> GetAll()
        {
            var sql = "SELECT * FROM artists";
            return _db.Query<Artist>(sql).ToList();
        }

        public Artist Create(Artist artistData)
        {   
            var sql = @"
            INSERT INTO artists(name, birthYear, deathYear)
            VALUES(@Name, @BirthYear, @DeathYear);
            SELECT LAST_INSERT_ID();
            ";

            int id = _db.ExecuteScalar<int>(sql, artistData);
            artistData.Id = id;
            return artistData;
            
            // FIXME this is terrible don't do it
            // never use string interpolation or concationation 
            // to build your sql statements
            
            // var sql = $@"INSERT INTO artists(name, birthYear, deathYear)
            //     VALUES({artistData.Name}, {artistData.BirthYear}, {artistData.DeathYear});
            //     SELECT LAST_ROW();";
            // return _db.ExecuteScalar<Artist>(sql);

        }
    }
}