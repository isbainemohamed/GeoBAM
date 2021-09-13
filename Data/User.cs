using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GeoBAM.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }             //Identifiant unique de l'utilisateur
        public string FirstName { get; set; }   //Prénom de l'utilisateur ( correspond à la colonne FirstName dans la table Users)
        public string LastName { get; set; }        //Nom de l'utilisateur ( correspond à la colonne LasttName dans la table Users)

        public string Email { get; set; }       //Email de l'utilisateur ( correspond à la colonne Email dans la table Users)
        public string Password { get; set; }        //Mot de passe de l'utilisateur ( correspond à la colonne Password dans la table Users)
        public string Role { get; set; }        //role de l'utilisateur ( correspond à la colonne Role dans la table Users)
    }
}