using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OdeToFood.Models;

namespace OdeToFood.Queries
{

    public static class Extension
    {
        public static IList<RestaurantReview> FindTheLatest(this IList<RestaurantReview> review, int num)
        {
            return review.OrderByDescending(o => o.Created)
                          .Take(num)
                          .ToList();
        }

        public static RestaurantReview FindById(this IList<RestaurantReview> review, int id)
        {
            return review.SingleOrDefault(s => id == s.ID);
        }

        public static RestaurantReview FindTheBest(this IList<RestaurantReview> list)
        {
            return list.OrderByDescending(o => o.Rating).FirstOrDefault();
        }
    }
}