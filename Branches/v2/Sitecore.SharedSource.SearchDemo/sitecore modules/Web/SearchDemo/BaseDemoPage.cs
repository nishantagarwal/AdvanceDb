﻿using System.Collections.Generic;
using System.Web.UI.WebControls;
using Sitecore.Search;
using Sitecore.SharedSource.Searcher;

namespace Sitecore.SharedSource.SearchDemo
{
   public abstract class BaseDemoPage : System.Web.UI.Page
   {
      protected QueryOccurance GetCondition(DropDownList list)
      {
         var selectedValue = int.Parse(list.SelectedValue);

         switch (selectedValue)
         {
            case 0:
               return QueryOccurance.Must;
            case 1:
               return QueryOccurance.MustNot;
            case 2:
               return QueryOccurance.Should;
            default:
               return QueryOccurance.Must;
         }
      }

      public abstract List<SkinnyItem> GetItems(string databaseName, string indexName, string language, string templateFilter,
                                                string locationFilter, string fullTextQuery);
   }
}