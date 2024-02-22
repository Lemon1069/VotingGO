using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
namespace VotingActivities
{
    public class VotingSystem
    {
        private DataContext dataContext { get; set; }

        public void Add (Candidate candidate)
        {
            using (dataContext = new DataContext())
            {
                dataContext.Candidates.Add(candidate);
                dataContext.SaveChanges();
            }
        }

        public void Delete (int id)
        {
            using (dataContext = new DataContext())
            {
                var candidate = dataContext.Candidates.Find(id);
                if (candidate != null)
                {
                    dataContext.Candidates.Remove(candidate);
                    dataContext.SaveChanges();
                }
                
            }
        }

        public List<Candidate> GetAll ()
        {
            using (dataContext = new DataContext())
            {
                return dataContext.Candidates.ToList();
            }
        }

        public Candidate Get (int id)
        {
            using (dataContext = new DataContext())
            {
                var candidate = dataContext.Candidates.Find(id);
                if (candidate != null)
                {
                    return candidate;
                }
                else
                {
                    throw new ArgumentException($"Candidate with id: {id} not found");
                }
            }
        }

        public void Update (Candidate candidate)
        {
            using (dataContext = new DataContext())
            {
                var item = dataContext.Candidates.Find(candidate.Id);
                if (item != null)
                {
                    dataContext.Entry(item).CurrentValues.SetValues(candidate);
                    dataContext.SaveChanges();
                }
            }
        }

        public void AddVote (int id)
        {
            using (dataContext = new DataContext())
            {
                var item = dataContext.Candidates.Find(id);
                if (item != null)
                {
                    item.AddVote();
                    dataContext.SaveChanges();
                }
            }
        }
    }
}
