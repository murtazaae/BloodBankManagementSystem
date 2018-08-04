using System;
using System.Collections.Generic;
using System.Text;
using BBMS.Data;
using BBMS.Repo;

namespace BBMS.Service
{
    public class DonorService : IDonorService
    {
        private IRepository<Donor> donorRepository;
        //private IRepository<UserProfile> userProfileRepository;

        public DonorService(IRepository<Donor> donorRepository)
        {
            this.donorRepository = donorRepository;
            //this.userProfileRepository = userProfileRepository;
        }

        public IEnumerable<Donor> GetDonors()
        {
            return donorRepository.GetAll();
        }

        public Donor GetDonor(long id)
        {
            return donorRepository.Get(id);
        }

        public void InsertDonor(Donor donor)
        {
            donorRepository.Insert(donor);
        }
        public void UpdateDonor(Donor donor)
        {
            donorRepository.Update(donor);
        }

        public void DeleteDonor(long id)
        {
            Donor donor = donorRepository.Get(id);
            donorRepository.Remove(donor);
            donorRepository.SaveChanges();
        }
    }
}
