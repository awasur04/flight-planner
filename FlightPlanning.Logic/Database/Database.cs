        public CreationStatus CreateUser(string email, string password, string name)
        {
            try
            {
                AccountDB acctDB = new AccountDB();
                (User, bool) newUser = acctDB.CreateUser(email, password, name);

                if (newUser.Item2)
                {
                    return CreationStatus.ACCT_ALREADY_EXISTS;
                }

                if (newUser.Item1.name != "ERROR")
                {
                    return CreationStatus.SUCCESS;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return CreationStatus.FAILURE;
        }

