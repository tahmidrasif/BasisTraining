﻿using System.Collections.Generic;
using UniversityLayerApp.DLL.DAO;
using UniversityLayerApp.DLL.GATEWAY;

namespace UniversityLayerApp.BLL
{
    class DepertmentBLL
    {
        DepertmentGateway aDepertmentGateway = new DepertmentGateway();

        public string CheckAndSave(Depertment aDepertment)
        {
            if (aDepertment.DepertmentName!=string.Empty||aDepertment.DepertmentCode!=string.Empty)
            {

                if (DepertmentNotAlreadyExists(aDepertment))
                {
                    int isAffected = aDepertmentGateway.SaveInDatabase(aDepertment);
                    if (isAffected > 0)
                    {
                        return "Data Saved In DataBase";
                    }
                    else
                    {
                        return "Something Wrong with Insertion";
                    }
                }
                return "Data is already Exist"; 
            }

            return @"Fill up all the fields";


        }

        private bool DepertmentNotAlreadyExists(Depertment aDepertment)
        {
            return aDepertmentGateway.Check(aDepertment);
        }

        public List<Depertment> Retrivedata()
        {

            return aDepertmentGateway.RetrivedataFromDatabase();
        }
    }
}
