using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PManage.Entities;
using PManage.DataLayer;


namespace Pmanage.BusinessLayer
{
    public class PensionerService
    {
        PensionerRepository pensionerRepository;
        public PensionerService()
        {
            pensionerRepository = new PensionerRepository();

        }
        public void AddPension(Pensioner pensioner)
        {
            try
            {
                pensionerRepository.AddPension(pensioner);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void DeletePension(int PensionerId)
        {
            try
            {
                pensionerRepository.DeletePensioner(PensionerId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdatePensioner(Pensioner pensioner)
        {
            try
            {
                pensionerRepository.UpdatePensioner(pensioner);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public Pensioner GetPensionerByID(int PensionerID)
        {
            try
            {
                return pensionerRepository.GetPensionerById(PensionerID);


            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Pensioner> GetPensioners()
        {
            try
            {
                return pensionerRepository.GetAllPensioners();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
