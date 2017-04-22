using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamagram.Models;
using Xamarin.Forms;

namespace Xamagram.Services
{
    static class CitiesServices
    {
        private static List<City> cities = buildCities();

        private static List<City> buildCities() {

            List<City> resultCities = new List<City>();

            City firstCity = new City();
            firstCity.id = "1";
            firstCity.name = "New York";
            firstCity.image = "http://www.planetware.com/photos-large/F/france-paris-eiffel-tower.jpg";
            firstCity.description = "Nueva York es la ciudad más poblada del estado homónimo y de los Estados Unidos de América, "
                + "y la tercera mayor concentración urbana del continente americano, después de Sao Paulo (Brasil) y la Ciudad de México. "
                + "La ciudad de Nueva York está entre las aglomeraciones urbanas más grandes y más pobladas del mundo.";
            firstCity.img = ImageSource.FromResource("Xamagram.Resources.Images.NewYork.png");
            resultCities.Add(firstCity);

            City secondCity = new City();
            secondCity.id = "2";
            secondCity.name = "Paris";
            secondCity.image = "http://www.planetware.com/photos-large/F/france-paris-eiffel-tower.jpg";
            secondCity.description = "París es la capital de Francia y su ciudad más poblada. Capital de la región de Isla de Francia"
                + ", es constituida en la única comuna unidepartamental del país. Está situada a ambos márgenes de "
                + "un largo meandro del río Sena, en el centro de la Cuenca parisina, entre la confluencia del río Marne y el Sena, "
                + "aguas arriba, y el Oise y el Sena, aguas abajo.";
            secondCity.img = ImageSource.FromResource("Xamagram.Resources.Images.Paris.png");
            resultCities.Add(secondCity);

            City thirdCity = new City();
            thirdCity.id = "3";
            thirdCity.name = "Roma";
            thirdCity.image = "http://www.planetware.com/photos-large/F/france-paris-eiffel-tower.jpg";
            thirdCity.description = "Roma es una ciudad y capital italiana, de 2 872 082 habitantes,1 2 capital de la Ciudad "
                + "metropolitana de Roma Capital, de la región del Lacio y de Italia. Es el municipio más poblado de Italia y es "
                + "la cuarta ciudad más poblada de la Unión Europea.3 Por antonomasia se la conoce como la Ciudad Eterna, l'Urbe "
                + "(‘la Ciudad’) o Città Eterna.";
            thirdCity.img = ImageSource.FromResource("Xamagram.Resources.Images.Roma.png");
            resultCities.Add(thirdCity);

            return resultCities;
        }

        public static List<City> getCities(string token) {
            if (String.IsNullOrEmpty(token)) {
                return null;
            }
            return cities;
        }

        public static City getCity(string token, string id) {
            if (!String.IsNullOrEmpty(token) && !String.IsNullOrEmpty(id)){
                foreach (City city in cities) {
                    if (city.id.Equals(id)) {
                        return city;
                    }
                }
            }
            return null;
        }

    }
}
