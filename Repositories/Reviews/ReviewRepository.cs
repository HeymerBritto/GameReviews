using GameReviews.Core.Entity;
using GameReviews.Models;
using GameReviews.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviews.Repositories.Reviews
{
    public class ReviewRepository : IRepository<Review>
    {
        private readonly GameReviewContext _context;

        public ReviewRepository(GameReviewContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public async Task<Review> AddAsync(Review review)
        {
            review.Id = new Guid();

            _context.Review.Add(review);
            await _context.SaveChangesAsync();

            return review;
        }

        public Task<Review> GetByIdAsync(Guid id)
        {
            return _context.Review.Where(m => m.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }
    }
}
