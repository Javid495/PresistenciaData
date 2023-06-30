using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PresistenciaData.Entities;
using Newtonsoft.Json;

namespace PresistenciaData
{

    public class Controlador
    {
        List<Team> team = new List<Team>();
        public Controlador(){
            if(!ExistFile()){
                CreateFile();
            }else{
  
            }
        }
        public bool ExistFile(){
            bool isValid = true;
            if (File.Exists("fifawc.json")){
                isValid = true;
            }
            else{
                isValid = false;
            }
            return isValid;
        }
        public void CreateFile(){
            if(!ExistFile()){
                File.Create("fifawc.json");
            }
        }

        public void AddInfo(){
            Team equipo = new Team();
            Console.WriteLine("Ingrese el Id del equipo: ");
            equipo.IdTeam = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del equipo: ");
            equipo.NameTeam = Console.ReadLine();
            team.Add(equipo);
            SaveDataFile();
        }
        public void EditDataFile(string Id){
            Team teamToEdit = team.FirstOrDefault(team => (team.IdTeam ?? string.Empty).Equals(Id)) ?? new Team();
            if (teamToEdit){

            }

        }
        public void SaveDataFile(){
            string json = JsonConvert.SerializeObject(team, Formatting.Indented);
            File.WriteAllText("fifawc.json",json);
        }
    }
    
}