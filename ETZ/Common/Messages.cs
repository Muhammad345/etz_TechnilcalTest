using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETZ.Common
{
    public static class Messages
    {

        public static class Repoistory
        {
            public static class Create
            {
                public const string Message = "New Record added successfully ";
            }

            public static class Update
            {
                public const string Message = "Record updated successfully ";
            }

            public static class Delete
            {
                public const string Message = "Record deleted successfully ";
            }


            public static class Error
            {
                public const string Message = "Please investigage Database repositry for ";
            }
        }
    }
}
