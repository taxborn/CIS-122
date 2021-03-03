// Created by: Braxton Fair
// Created on: 03/02/2021

namespace InterfacesPt2
{
    public class Surgeon : Cutter, Cutable
    {
        public string Cut()
        {
            return "Using a scaple to cut away the tumor!";
        }
    }
}
