using System;
using Practice8.models;
using System.Collections.Generic;


namespace Practice8.controllers
{
        class Garage
        {

            protected List<Car> cars = new List<Car>();

            public void AddCar(Car car)
            {
                cars.Add(car);
            }

            public void DeleteCar(Car car)
            {
                cars.Remove(car);
            }

            public HashSet<Car> SearchCars(Car car) {
                return CarSearch.chooseCarAccordingToTheParameters(this, car);
            }

            public List<Car> GetCars()
            {
                return this.cars;
            }

        }

        class CarSearch
        {
            public static HashSet<Car> chooseCarAccordingToTheParameters(Garage garage, Car carYouAreLookingFor)
            {
                HashSet<Car> result = new HashSet<Car>();

 
                foreach (Car car in garage.GetCars())
                {

                    if (!carYouAreLookingFor.getBrand().Equals(""))
                    {
                        if (car.getBrand().Equals(carYouAreLookingFor.getBrand()))
                        {
                            result.Add(car);
                        }
                    }

                    if (!carYouAreLookingFor.getColor().Equals(""))
                    {
                        if (car.getColor().Equals(carYouAreLookingFor.getColor()))
                        {
                            result.Add(car);
                        }
                    }


                    if (carYouAreLookingFor.getMaxSpeed() != 0)
                    {
                        if (car.getMaxSpeed() == carYouAreLookingFor.getMaxSpeed())
                        {
                            result.Add(car);
                        }
                    }

                    if (!carYouAreLookingFor.getYearOfIssue().Equals(null))
                    {
                        if (car.getYearOfIssue().Equals(carYouAreLookingFor.getYearOfIssue()))
                        {
                            result.Add(car);
                        }
                    }
                }
                return result;
            }
       
        }

}