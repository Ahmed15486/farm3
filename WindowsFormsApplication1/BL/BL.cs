using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1.BL
{
    public class BL
    {
        public struct Users
        {
            #region Var
            public int ID;
            public string Name;
            public string Password;
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable Users = new DataTable();
                Users = dal.Select("Select * From Users");

                return Users;
            }
            public string Insert()
            {
                DAL.DAL dal = new DAL.DAL();


                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[0].Value = Name;

                param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                param[1].Value = Password;

                string F;
                F = dal.ExecuteCommand("Insert Into Users (Name,Password) Values (@Name , @Password)", param);

                return F;
            }
            public string Update()
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[3];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                param[2].Value = Password;

                string F;
                F = dal.ExecuteCommand("Update Users Set Name = @Name , Password = @Password Where ID = @ID", param);
                return F;
            }
            public string Delete()
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                string f;
                f = dal.ExecuteCommand2("delete from users where id = @ID", param);
                return f;
            }
        }

        public struct Update
        {
            public int Check()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select max(last_Update) from sys;");
                if (dt.Rows[0][0].ToString() == "") return 0;
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            public int update(string s, int max)
            {
                string select = "  insert into sys (last_Update) values(@max);  select max(last_Update) from sys;";
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@max", SqlDbType.Int);
                param[0].Value = max;

                dt = dal.Select(s + select, param);

                if (dt.Rows.Count == 0) return 0;
                if (dt.Rows[0][0].ToString() == "") return 0;
                return Convert.ToInt32(dt.Rows[0][0]);
            }
        }

        public struct BS
        {
            #region var
            public int User_ID;
            public string Branche_ID;
            public string Anm;
            public string Enm;
            public int Store_ID;
            public string Store_Anm;
            public string Store_Enm;
            #endregion

            public DataTable Select_All_Branches()
            {
                DAL.DAL DAL = new DAL.DAL();

                DataTable Branches = new DataTable();
                Branches = DAL.Select("Branches_Select");

                return Branches;
            }
            public DataTable Select_All_Stores()
            {
                DAL.DAL DAL = new DAL.DAL();

                DataTable Stores = new DataTable();
                Stores = DAL.Select("Stores_Select");

                return Stores;
            }

            public string Insert_Branche()
            {
                DAL.DAL DAL = new DAL.DAL();
                string r;

                string s = "Begin Transaction;"
                         + " INSERT INTO [Branches] ([ID] ,[Anm] ,[Enm])"
                         + " VALUES('" + Branche_ID + "','" + Anm + "','" + Enm + "');"

                         + " INSERT INTO [Stores]"
                         + "([Anm],[Enm],[Branche_ID])"
                         + "VALUES('" + Store_Anm + "','" + Store_Enm + "','" + Branche_ID + "');"

                         + " Commit Transaction;";
                try
                {
                    r = DAL.ExecuteCommand(s);
                }
                catch (Exception ex)
                {
                    return "Error " + ex.Message;
                }
                return r;
            }
            public string Update_Branche()
            {
                DAL.DAL DAL = new DAL.DAL();
                string r;

                string s = "Begin Transaction;"

                         + " Update [Branches]"
                         + " Set [Anm] = '" + Anm + "'"
                         + " , [Enm] = '" + Enm + "'"
                         + " Where [ID] = '" + Branche_ID + "';"

                         + " Commit Transaction;";
                try
                {
                    r = DAL.ExecuteCommand(s);
                }
                catch (Exception ex)
                {
                    return "Error " + ex.Message;
                }
                return r;
            }
            public string Delete_Branche()
            {
                DAL.DAL DAL = new DAL.DAL();
                string r;

                string s = "Begin Transaction;"

                         + " Delete From [Branches] Where [ID] = '" + Branche_ID + "';"
                         + " Delete From [Stores] Where [Branche_ID] = '" + Branche_ID + "';"

                         + " Commit Transaction;";
                try
                {
                    r = DAL.ExecuteCommand(s);
                }
                catch (Exception ex)
                {
                    return "Error " + ex.Message;
                }
                return r;
            }

            public string Insert_Store()
            {
                DAL.DAL DAL = new DAL.DAL();
                string r;

                string s = "Begin Transaction;"

                         + " INSERT INTO [Stores]"
                         + " ([Anm],[Enm],[Branche_ID])"
                         + " VALUES('" + Store_Anm + "','" + Store_Enm + "','" + Branche_ID + "');"

                         + " Commit Transaction;";
                try
                {
                    r = DAL.ExecuteCommand(s);
                }
                catch (Exception ex)
                {
                    return "Error " + ex.Message;
                }
                return r;
            }
            public string Update_Store()
            {
                DAL.DAL DAL = new DAL.DAL();
                string r;

                string s = "Begin Transaction;"

                         + " Update [Stores]"
                         + " Set [Anm] = '" + Store_Anm + "'"
                         + "    ,[Enm] = '" + Store_Enm + "'"
                         + "    ,[Branche_ID] = '" + Branche_ID + "'"
                         + " Where [ID] = " + Store_ID + ";"

                         + " Commit Transaction;";
                try
                {
                    r = DAL.ExecuteCommand(s);
                }
                catch (Exception ex)
                {
                    return "Error " + ex.Message;
                }
                return r;
            }
            public string Delete_Store()
            {
                DAL.DAL DAL = new DAL.DAL();
                string r;

                string s = "Begin Transaction;"

                         + " Delete From [Stores] Where [ID] = " + Store_ID + ";"

                         + " Commit Transaction;";
                try
                {
                    r = DAL.ExecuteCommand(s);
                }
                catch (Exception ex)
                {
                    return "Error " + ex.Message;
                }
                return r;
            }
        }

        public struct G
        {
            #region var
            public int ID { get; set; }
            public string Name { get; set; }
            #endregion

            public bool RunSqlServerScript(string path)
            {
                bool result;
                DAL.DAL dal = new DAL.DAL();
                result = dal.runSqlScriptFile(path);

                if(result == true)
                {
                    MessageBox.Show("تم التنفيذ بنجاح","تنفيذ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                return result;
            }

            public string ExecuteCommand(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                return dal.ExecuteCommand(s);
            }
            public DataTable Select(string Table)
            {
                DAL.DAL dal = new DAL.DAL();
                return dal.Select("select * from [" + Table + "]");
            }
            public DataTable Select2(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                return dal.Select(s);
            }
            public DataSet SelectDS(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                return dal.Select_Multi(s);
            }
            public void Insert(string Table)
            {
                DAL.DAL dal = new DAL.DAL();
                dal.ExecuteCommand("Insert Into " + Table + " (Name) Values ('" + Name + "')");
            }
            public void Update(string Table)
            {
                DAL.DAL dal = new DAL.DAL();
                dal.ExecuteCommand("Update " + Table + " Set Name = '" + Name + "' Where ID = " + ID);
            }
            public void Delete(string Table)
            {
                DAL.DAL dal = new DAL.DAL();
                dal.ExecuteCommand("Delete From " + Table + " Where ID = " + ID);
            }

            public void Cancel_Alarms( string where)
            {
                DAL.DAL dal = new DAL.DAL();
                dal.ExecuteCommand("Update [Tat3eemShow] Set Cancel = 1 " + where);
            }
            public int BackupDatabase(string path)
            {
                DAL.DAL dal = new DAL.DAL();
                return dal.BackupDatabase(path);
            }
            public int RestoreDatabase(string path)
            {
                DAL.DAL dal = new DAL.DAL();
                return dal.RestoreDatabase(path);
            }
        }

        #region ACC

        public struct ACC
        {
            #region var
            public string ID { get; set; }
            public string Name { get; set; }
            public int ACCProperID { get; set; }
            public int Level { get; set; }
            public string ParentID { get; set; }
            public int UserID { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("ACC_Select", null);
                return dt;
            }
            public DataTable Select2()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select * from  ACC where Parent = 0");
                return dt;
            }
            public DataTable Select3(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select(s);
                return dt;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[0].Value = Name;

                param[1] = new SqlParameter("@ACCProperID", SqlDbType.Int);
                param[1].Value = ACCProperID;

                param[2] = new SqlParameter("@ParentID", SqlDbType.VarChar, 50);
                param[2].Value = ParentID;

                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = UserID;


                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("ACC_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@ACCProperID", SqlDbType.Int);
                param[2].Value = ACCProperID;

                param[3] = new SqlParameter("@ParentID", SqlDbType.VarChar, 50);
                param[3].Value = ParentID;

                param[4] = new SqlParameter("@UserID", SqlDbType.Int);
                param[4].Value = UserID;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("ACC_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("ACC_Delete", param);

                return d;
            }
        }

        public struct ACC_Settings
        {
            #region Levels
            #region var Level
            public int n1;
            public int n2;
            public int n3;
            public int n4;
            public int n5;
            public int n6;
            public int n7;
            public int n8;
            public int n9;
            public int n10;

            public int cc1;
            public int cc2;
            public int cc3;
            public int cc4;
            public int cc5;
            public int cc6;
            public int cc7;
            public int cc8;
            public int cc9;
            public int cc10;

            public int i1;
            public int i2;
            public int i3;
            public int i4;
            public int i5;
            public int i6;
            public int i7;
            public int i8;
            public int i9;
            public int i10;

            public int i21;
            public int i22;
            public int i23;
            public int i24;
            public int i25;
            public int i26;
            public int i27;
            public int i28;
            public int i29;
            public int i210;
            #endregion
            public DataTable Select_Level_Set()
            {
                DAL.DAL dal = new DAL.DAL();

                var ACC = new DataTable();
                ACC = dal.Select("SELECT * FROM [dbo].[LevelSet]");

                return ACC;
            }
            public string Update_Level_Set()
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[40];

                param[0] = new SqlParameter("@n1", SqlDbType.Int);
                param[0].Value = n1;

                param[1] = new SqlParameter("@n2", SqlDbType.Int);
                param[1].Value = n2;

                param[2] = new SqlParameter("@n3", SqlDbType.Int);
                param[2].Value = n3;

                param[3] = new SqlParameter("@n4", SqlDbType.Int);
                param[3].Value = n4;

                param[4] = new SqlParameter("@n5", SqlDbType.Int);
                param[4].Value = n5;

                param[5] = new SqlParameter("@n6", SqlDbType.Int);
                param[5].Value = n6;

                param[6] = new SqlParameter("@n7", SqlDbType.Int);
                param[6].Value = n7;

                param[7] = new SqlParameter("@n8", SqlDbType.Int);
                param[7].Value = n8;

                param[8] = new SqlParameter("@n9", SqlDbType.Int);
                param[8].Value = n9;

                param[9] = new SqlParameter("@n10", SqlDbType.Int);
                param[9].Value = n10;

                param[10] = new SqlParameter("@cc1", SqlDbType.Int);
                param[10].Value = cc1;

                param[11] = new SqlParameter("@cc2", SqlDbType.Int);
                param[11].Value = cc2;

                param[12] = new SqlParameter("@cc3", SqlDbType.Int);
                param[12].Value = cc3;

                param[13] = new SqlParameter("@cc4", SqlDbType.Int);
                param[13].Value = cc4;

                param[14] = new SqlParameter("@cc5", SqlDbType.Int);
                param[14].Value = cc5;

                param[15] = new SqlParameter("@cc6", SqlDbType.Int);
                param[15].Value = cc6;

                param[16] = new SqlParameter("@cc7", SqlDbType.Int);
                param[16].Value = cc7;

                param[17] = new SqlParameter("@cc8", SqlDbType.Int);
                param[17].Value = cc8;

                param[18] = new SqlParameter("@cc9", SqlDbType.Int);
                param[18].Value = cc9;

                param[19] = new SqlParameter("@cc10", SqlDbType.Int);
                param[19].Value = cc10;

                param[20] = new SqlParameter("@i1", SqlDbType.Int);
                param[20].Value = i1;

                param[21] = new SqlParameter("@i2", SqlDbType.Int);
                param[21].Value = i2;

                param[22] = new SqlParameter("@i3", SqlDbType.Int);
                param[22].Value = i3;

                param[23] = new SqlParameter("@i4", SqlDbType.Int);
                param[23].Value = i4;

                param[24] = new SqlParameter("@i5", SqlDbType.Int);
                param[24].Value = i5;

                param[25] = new SqlParameter("@i6", SqlDbType.Int);
                param[25].Value = i6;

                param[26] = new SqlParameter("@i7", SqlDbType.Int);
                param[26].Value = i7;

                param[27] = new SqlParameter("@i8", SqlDbType.Int);
                param[27].Value = i8;

                param[28] = new SqlParameter("@i9", SqlDbType.Int);
                param[28].Value = i9;

                param[29] = new SqlParameter("@i10", SqlDbType.Int);
                param[29].Value = i10;

                param[30] = new SqlParameter("@i21", SqlDbType.Int);
                param[30].Value = i21;

                param[31] = new SqlParameter("@i22", SqlDbType.Int);
                param[31].Value = i22;

                param[32] = new SqlParameter("@i23", SqlDbType.Int);
                param[32].Value = i23;

                param[33] = new SqlParameter("@i24", SqlDbType.Int);
                param[33].Value = i24;

                param[34] = new SqlParameter("@i25", SqlDbType.Int);
                param[34].Value = i25;

                param[35] = new SqlParameter("@i26", SqlDbType.Int);
                param[35].Value = i26;

                param[36] = new SqlParameter("@i27", SqlDbType.Int);
                param[36].Value = i27;

                param[37] = new SqlParameter("@i28", SqlDbType.Int);
                param[37].Value = i28;

                param[38] = new SqlParameter("@i29", SqlDbType.Int);
                param[38].Value = i29;

                param[39] = new SqlParameter("@i210", SqlDbType.Int);
                param[39].Value = i210;

                string F;
                F = dal.ExecuteCommand("LevelSet_Update", param);
                return F;
            }
            #endregion
        }

        public struct Ven
        {
            #region var
            public int ID { get; set; }
            public string Name { get; set; }
            public string RespoName { get; set; }
            public string Mobile1 { get; set; }
            public string Mobile2 { get; set; }
            public string Phone1 { get; set; }
            public string Phone2 { get; set; }
            public string Email { get; set; }
            public decimal Balance { get; set; }
            public string ParentACCID { get; set; }
            public int UserID { get; set; }


            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Ven_Select", null);
                return dt;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[9];

                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[0].Value = Name;

                param[1] = new SqlParameter("@RespoName", SqlDbType.NVarChar, 50);
                param[1].Value = RespoName;

                param[2] = new SqlParameter("@Mobile1", SqlDbType.VarChar, 50);
                param[2].Value = Mobile1;

                param[3] = new SqlParameter("@Mobile2", SqlDbType.VarChar, 50);
                param[3].Value = Mobile2;

                param[4] = new SqlParameter("@Phone1", SqlDbType.VarChar, 50);
                param[4].Value = Phone1;

                param[5] = new SqlParameter("@Phone2", SqlDbType.VarChar, 50);
                param[5].Value = Phone2;

                param[6] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                param[6].Value = Email;

                param[7] = new SqlParameter("@ParentACCID", SqlDbType.VarChar, 50);
                param[7].Value = ParentACCID;

                param[8] = new SqlParameter("@UserID", SqlDbType.Int);
                param[8].Value = UserID;


                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Ven_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@RespoName", SqlDbType.NVarChar, 50);
                param[2].Value = RespoName;

                param[3] = new SqlParameter("@Mobile1", SqlDbType.VarChar, 50);
                param[3].Value = Mobile1;

                param[4] = new SqlParameter("@Mobile2", SqlDbType.VarChar, 50);
                param[4].Value = Mobile2;

                param[5] = new SqlParameter("@Phone1", SqlDbType.VarChar, 50);
                param[5].Value = Phone1;

                param[6] = new SqlParameter("@Phone2", SqlDbType.VarChar, 50);
                param[6].Value = Phone2;

                param[7] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                param[7].Value = Email;

                param[8] = new SqlParameter("@ParentACCID", SqlDbType.VarChar, 50);
                param[8].Value = ParentACCID;

                param[9] = new SqlParameter("@UserID", SqlDbType.Int);
                param[9].Value = UserID;


                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Ven_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Ven_Delete", param);

                return d;
            }
        }

        public struct Cust
        {
            #region var
            public int ID { get; set; }
            public string Name { get; set; }
            public string RespoName { get; set; }
            public string Mobile1 { get; set; }
            public string Mobile2 { get; set; }
            public string Phone1 { get; set; }
            public string Phone2 { get; set; }
            public string Email { get; set; }
            public decimal Balance { get; set; }
            public string ParentACCID { get; set; }
            public int UserID { get; set; }


            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Cust_Select", null);
                return dt;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[9];

                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[0].Value = Name;

                param[1] = new SqlParameter("@RespoName", SqlDbType.NVarChar, 50);
                param[1].Value = RespoName;

                param[2] = new SqlParameter("@Mobile1", SqlDbType.VarChar, 50);
                param[2].Value = Mobile1;

                param[3] = new SqlParameter("@Mobile2", SqlDbType.VarChar, 50);
                param[3].Value = Mobile2;

                param[4] = new SqlParameter("@Phone1", SqlDbType.VarChar, 50);
                param[4].Value = Phone1;

                param[5] = new SqlParameter("@Phone2", SqlDbType.VarChar, 50);
                param[5].Value = Phone2;

                param[6] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                param[6].Value = Email;

                param[7] = new SqlParameter("@ParentACCID", SqlDbType.VarChar, 50);
                param[7].Value = ParentACCID;

                param[8] = new SqlParameter("@UserID", SqlDbType.Int);
                param[8].Value = UserID;


                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Cust_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@RespoName", SqlDbType.NVarChar, 50);
                param[2].Value = RespoName;

                param[3] = new SqlParameter("@Mobile1", SqlDbType.VarChar, 50);
                param[3].Value = Mobile1;

                param[4] = new SqlParameter("@Mobile2", SqlDbType.VarChar, 50);
                param[4].Value = Mobile2;

                param[5] = new SqlParameter("@Phone1", SqlDbType.VarChar, 50);
                param[5].Value = Phone1;

                param[6] = new SqlParameter("@Phone2", SqlDbType.VarChar, 50);
                param[6].Value = Phone2;

                param[7] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                param[7].Value = Email;

                param[8] = new SqlParameter("@ParentACCID", SqlDbType.VarChar, 50);
                param[8].Value = ParentACCID;

                param[9] = new SqlParameter("@UserID", SqlDbType.Int);
                param[9].Value = UserID;


                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Cust_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Cust_Delete", param);

                return d;
            }
        }

        public struct PayIn
        {
            #region var
            public string ID { get; set; }
            public DateTime Date { get; set; }
            public string No { get; set; }
            public int PayTypeID { get; set; }
            public string ChekNo { get; set; }
            public DateTime? CheckDate { get; set; }
            public decimal Value { get; set; }
            public string ACCID { get; set; }
            public string Notes { get; set; }
            public int UserID { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("PayIn_Select", null);
                return dt;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[9];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[1].Value = PayTypeID;

                param[2] = new SqlParameter("@No", SqlDbType.VarChar, 100);
                param[2].Value = No;

                param[3] = new SqlParameter("@Value", SqlDbType.Decimal);
                param[3].Value = Value;

                param[4] = new SqlParameter("@ACCID", SqlDbType.VarChar, 50);
                param[4].Value = ACCID;

                param[5] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[5].Value = Notes;

                param[6] = new SqlParameter("@UserID", SqlDbType.Int);
                param[6].Value = UserID;

                param[7] = new SqlParameter("@ChekNo", SqlDbType.VarChar, 50);
                param[7].Value = ChekNo;

                param[8] = new SqlParameter("@ChekDate", SqlDbType.DateTime);
                param[8].Value = CheckDate;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("PayIn_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[2].Value = PayTypeID;

                param[3] = new SqlParameter("@No", SqlDbType.VarChar, 100);
                param[3].Value = No;

                param[4] = new SqlParameter("@Value", SqlDbType.Decimal);
                param[4].Value = Value;

                param[5] = new SqlParameter("@ACCID", SqlDbType.VarChar, 50);
                param[5].Value = ACCID;

                param[6] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[6].Value = Notes;

                param[7] = new SqlParameter("@UserID", SqlDbType.Int);
                param[7].Value = UserID;

                param[8] = new SqlParameter("@ChekNo", SqlDbType.VarChar, 50);
                param[8].Value = ChekNo;

                param[9] = new SqlParameter("@ChekDate", SqlDbType.DateTime);
                param[9].Value = CheckDate;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("PayIn_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("PayIn_Delete", param);

                return d;
            }
        }

        public struct PayOut
        {
            #region var
            public string ID { get; set; }
            public DateTime Date { get; set; }
            public string No { get; set; }
            public int PayTypeID { get; set; }
            public string ChekNo { get; set; }
            public DateTime? CheckDate { get; set; }
            public decimal Value { get; set; }
            public string ACCID { get; set; }
            public string Notes { get; set; }
            public int UserID { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("PayOut_Select", null);
                return dt;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[9];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[1].Value = PayTypeID;

                param[2] = new SqlParameter("@No", SqlDbType.VarChar, 100);
                param[2].Value = No;

                param[3] = new SqlParameter("@Value", SqlDbType.Decimal);
                param[3].Value = Value;

                param[4] = new SqlParameter("@ACCID", SqlDbType.VarChar, 50);
                param[4].Value = ACCID;

                param[5] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[5].Value = Notes;

                param[6] = new SqlParameter("@UserID", SqlDbType.Int);
                param[6].Value = UserID;

                param[7] = new SqlParameter("@ChekNo", SqlDbType.VarChar, 50);
                param[7].Value = ChekNo;

                param[8] = new SqlParameter("@ChekDate", SqlDbType.DateTime);
                param[8].Value = CheckDate;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("PayOut_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[2].Value = PayTypeID;

                param[3] = new SqlParameter("@No", SqlDbType.VarChar, 100);
                param[3].Value = No;

                param[4] = new SqlParameter("@Value", SqlDbType.Decimal);
                param[4].Value = Value;

                param[5] = new SqlParameter("@ACCID", SqlDbType.VarChar, 50);
                param[5].Value = ACCID;

                param[6] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[6].Value = Notes;

                param[7] = new SqlParameter("@UserID", SqlDbType.Int);
                param[7].Value = UserID;

                param[8] = new SqlParameter("@ChekNo", SqlDbType.VarChar, 50);
                param[8].Value = ChekNo;

                param[9] = new SqlParameter("@ChekDate", SqlDbType.DateTime);
                param[9].Value = CheckDate;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("PayOut_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("PayOut_Delete", param);

                return d;
            }
        }

        public struct Jor
        {
            #region var
            public string nav { get; set; }
            public string ID { get; set; }
            public string xID { get; set; }
            public string BrancheID { get; set; }
            public string yy { get; set; }
            public string CC1ID { get; set; }
            public string CC2ID { get; set; }
            public int UserID { get; set; }
            public DateTime Date { get; set; }
            public string Notes { get; set; }
            public int JorTypeID { get; set; }
            public DataTable JorD { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@nav", SqlDbType.VarChar, 10);
                param[0].Value = nav;

                param[1] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[1].Value = ID;

                param[2] = new SqlParameter("@xID", SqlDbType.VarChar, 4);
                param[2].Value = xID;

                param[3] = new SqlParameter("@Branche_ID", SqlDbType.VarChar, 3);
                param[3].Value = BrancheID;

                param[4] = new SqlParameter("@yy", SqlDbType.VarChar, 2);
                param[4].Value = yy;

                st = dal.Select_Multi("Jor_Select", param);
                return st;
            }
            public DataTable Select2()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select * from  ACC where Parent = 0");
                return dt;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[8];

                param[0] = new SqlParameter("@BrancheID", SqlDbType.VarChar, 3);
                param[0].Value = "001";

                param[1] = new SqlParameter("@CC1ID", SqlDbType.VarChar, 50);
                param[1].Value = CC1ID;

                param[2] = new SqlParameter("@CC2ID", SqlDbType.VarChar, 50);
                param[2].Value = CC2ID;

                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = UserID;

                param[4] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[4].Value = Date;

                param[5] = new SqlParameter("@Notes", SqlDbType.NVarChar, 100);
                param[5].Value = Notes;

                param[6] = new SqlParameter("@JorTypeID", SqlDbType.Int);
                param[6].Value = JorTypeID;

                param[7] = new SqlParameter("@JorD", SqlDbType.Structured);
                param[7].Value = JorD;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Jor_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[9];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                param[0].Value = xID;

                param[1] = new SqlParameter("@BrancheID", SqlDbType.VarChar, 3);
                param[1].Value = "001";

                param[2] = new SqlParameter("@CC1ID", SqlDbType.VarChar, 50);
                param[2].Value = CC1ID;

                param[3] = new SqlParameter("@CC2ID", SqlDbType.VarChar, 50);
                param[3].Value = CC2ID;

                param[4] = new SqlParameter("@UserID", SqlDbType.Int);
                param[4].Value = UserID;

                param[5] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[5].Value = Date;

                param[6] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[6].Value = Notes;

                param[7] = new SqlParameter("@JorTypeID", SqlDbType.Int);
                param[7].Value = JorTypeID;

                param[8] = new SqlParameter("@JorD", SqlDbType.Structured);
                param[8].Value = JorD;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Jor_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                param[0].Value = xID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Jor_Delete", param);

                return d;
            }
        }

        public struct JorB
        {
            #region var
            public string BrancheID { get; set; }
            public int DocTypeID { get; set; }
            public int DocPayTypeID { get; set; }
            public DataTable dt_JorB { get; set; }
            #endregion

            public DataSet JorB_StartSelect()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();
                st = dal.Select_Multi("JorB_StartSelect", null);

                return st;
            }
            public DataTable JorB_Select()
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@DocTypeID", SqlDbType.Int);
                param[0].Value = DocTypeID;

                param[1] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[1].Value = DocPayTypeID;

                return dal.Select("JorB_Select", param); ;
            }
            public string JorB_Insert()
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@BrancheID", SqlDbType.VarChar, 3);
                param[0].Value = "001";

                param[1] = new SqlParameter("@DocTypeID", SqlDbType.Int);
                param[1].Value = DocTypeID;

                param[2] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[2].Value = DocPayTypeID;

                param[3] = new SqlParameter("@dt_JorB", SqlDbType.Structured);
                param[3].Value = dt_JorB;

                string F;
                F = dal.ExecuteCommand("JorB_Insert", param);
                return F;
            }
        }
        #endregion

        #region Stores
        public struct Items2
        {
            #region var
            public string ID { get; set; }
            public string Name { get; set; }
            public decimal PPrice { get; set; }
            public decimal SPrice { get; set; }
            public decimal CPrice { get; set; }
            public decimal Quan { get; set; }
            public int Unit { get; set; }
            public int Level { get; set; }
            public bool Parent { get; set; }
            public string ParentID { get; set; }
            public int UserID { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Items2_Select", null);
                return dt;
            }
            public DataTable Select2()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select * from  Items2 where Parent = 0");
                return dt;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[8];

                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[0].Value = Name;

                param[1] = new SqlParameter("@PPrice", SqlDbType.Decimal);
                param[1].Value = PPrice;

                param[2] = new SqlParameter("@SPrice", SqlDbType.Decimal);
                param[2].Value = SPrice;

                param[3] = new SqlParameter("@CPrice", SqlDbType.Decimal);
                param[3].Value = CPrice;

                param[4] = new SqlParameter("@Quan", SqlDbType.Decimal);
                param[4].Value = Quan;

                param[5] = new SqlParameter("@Unit", SqlDbType.Int);
                param[5].Value = Unit;

                param[6] = new SqlParameter("@Level", SqlDbType.Int);
                param[6].Value = Level;

                param[7] = new SqlParameter("@ParentID", SqlDbType.VarChar, 50);
                param[7].Value = ParentID;


                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Items2_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@PPrice", SqlDbType.Decimal);
                param[2].Value = PPrice;

                param[3] = new SqlParameter("@SPrice", SqlDbType.Decimal);
                param[3].Value = SPrice;

                param[4] = new SqlParameter("@CPrice", SqlDbType.Decimal);
                param[4].Value = CPrice;

                param[5] = new SqlParameter("@Quan", SqlDbType.Decimal);
                param[5].Value = Quan;

                param[6] = new SqlParameter("@Unit", SqlDbType.Int);
                param[6].Value = Unit;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Items2_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Items2_Delete", param);

                return d;
            }
        }
        public struct Items
        {
            #region var
            public string ID { get; set; }
            public string No { get; set; }
            public string Name { get; set; }
            public int Sex { get; set; }
            public int Cat { get; set; }
            public int ItemType { get; set; }
            public DateTime? BDate { get; set; }
            public DateTime? DDate { get; set; }
            public int Farm { get; set; }
            public decimal Age { get; set; }
            public decimal Weight { get; set; }
            public int Case { get; set; }
            public decimal Cost { get; set; }
            public byte[] Pic { get; set; }
            public int Level { get; set; }
            public bool Parent { get; set; }
            public string ParentID { get; set; }
            public string MomNo { get; set; }
            public int HealthStatus { get; set; }
            public  string Notes { get; set; }
            public DataTable dt_WhenInsert { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Items_Select", null);
                return dt;
            }
            public DataTable Select2()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select * from  Items where Parent = 0 AND Sold = 0");
                return dt;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[16];

                param[0] = new SqlParameter("@No", SqlDbType.VarChar, 50);
                param[0].Value = No;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@Sex", SqlDbType.Int);
                param[2].Value = Sex;

                param[3] = new SqlParameter("@Cat", SqlDbType.Int);
                param[3].Value = Cat;

                param[4] = new SqlParameter("@BDate", SqlDbType.DateTime);
                param[4].Value = BDate;

                param[5] = new SqlParameter("@Farm", SqlDbType.Int);
                param[5].Value = Farm;

                param[6] = new SqlParameter("@Weight", SqlDbType.Decimal);
                param[6].Value = Weight;

                param[7] = new SqlParameter("@Cost", SqlDbType.Decimal);
                param[7].Value = Cost;

                param[8] = new SqlParameter("@Case", SqlDbType.Int);
                param[8].Value = Case;

                param[9] = new SqlParameter("@Pic", SqlDbType.VarBinary);
                param[9].Value = Pic;

                param[10] = new SqlParameter("@ParentID", SqlDbType.VarChar, 50);
                param[10].Value = ParentID;

                param[11] = new SqlParameter("@ItemType", SqlDbType.Int);
                param[11].Value = ItemType;

                param[12] = new SqlParameter("@MomNo", SqlDbType.VarChar, 50);
                param[12].Value = MomNo;

                param[13] = new SqlParameter("@HealthStatus", SqlDbType.Int);
                param[13].Value = HealthStatus;

                param[14] = new SqlParameter("@Notes", SqlDbType.VarChar, 500);
                param[14].Value = Notes;

                param[15] = new SqlParameter("@dt_WhenInsert", SqlDbType.Structured);
                param[15].Value = dt_WhenInsert;


                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Items_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[15];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                param[0].Value = ID;

                param[1] = new SqlParameter("@No", SqlDbType.VarChar, 50);
                param[1].Value = No;

                param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[2].Value = Name;

                param[3] = new SqlParameter("@Sex", SqlDbType.Int);
                param[3].Value = Sex;

                param[4] = new SqlParameter("@Cat", SqlDbType.Int);
                param[4].Value = Cat;

                param[5] = new SqlParameter("@BDate", SqlDbType.DateTime);
                param[5].Value = BDate;

                param[6] = new SqlParameter("@Farm", SqlDbType.Int);
                param[6].Value = Farm;

                param[7] = new SqlParameter("@Case", SqlDbType.Int);
                param[7].Value = Case;

                param[8] = new SqlParameter("@Pic", SqlDbType.VarBinary);
                param[8].Value = Pic;

                param[9] = new SqlParameter("@Weight", SqlDbType.Decimal);
                param[9].Value = Weight;

                param[10] = new SqlParameter("@Cost", SqlDbType.Decimal);
                param[10].Value = Cost;

                param[11] = new SqlParameter("@ItemType", SqlDbType.Int);
                param[11].Value = ItemType;

                param[12] = new SqlParameter("@MomNo", SqlDbType.VarChar, 50);
                param[12].Value = MomNo;

                param[13] = new SqlParameter("@HealthStatus", SqlDbType.Int);
                param[13].Value = HealthStatus;

                param[14] = new SqlParameter("@Notes", SqlDbType.VarChar, 500);
                param[14].Value = Notes;


                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Items_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Items_Delete", param);

                return d;
            }
            public string Death_Insert()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("ItemsDeath_Insert", param);

                return d;
            }
        }

        struct ItemType
        {
            #region var
            public int ID { get; set; }
            public string Name { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select * From ItemType");
                return dt;
            }
            public string Insert()
            {
                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("INSERT INTO [dbo].[ItemType] ([Name]) VALUES (" + Name + ")");

                return ID;
            }
            public string Update()
            {
                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("UPDATE [dbo].[ItemType] SET [Name] = " + Name + " WHERE ID = " + ID);

                return id;
            }
            public string Delete()
            {
                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("DELETE FROM [dbo].[ItemType] WHERE ID = " + ID);

                return d;
            }
        }

        public struct Units
        {
            #region var
            public int ID { get; set; }
            public string Name { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select * From Units");
                return dt;
            }
            public string Insert()
            {
                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("INSERT INTO [dbo].[Units] ([Name]) VALUES (" + Name + ")");

                return ID;
            }
            public string Update()
            {
                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("UPDATE [dbo].[Units] SET [Name] = " + Name + " WHERE ID = " + ID);

                return id;
            }
            public string Delete()
            {
                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("DELETE FROM [dbo].[Units] WHERE ID = " + ID);

                return d;
            }
        }
        struct Cat
        {
            #region var
            public int ID { get; set; }
            public string Name { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select * From Cat");
                return dt;
            }
            public string Insert()
            {
                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("INSERT INTO [dbo].[Cat] ([Name]) VALUES (" + Name + ")");

                return ID;
            }
            public string Update()
            {
                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("UPDATE [dbo].[Cat] SET [Name] = " + Name + " WHERE ID = " + ID);

                return id;
            }
            public string Delete()
            {
                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("DELETE FROM [dbo].[Cat] WHERE ID = " + ID);

                return d;
            }
        }

        struct Farm
        {
            #region var
            public int ID { get; set; }
            public string Name { get; set; }
            #endregion

            public DataTable Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataTable dt = new DataTable();

                dt = dal.Select("Select * From Farm");
                return dt;
            }
            public string Insert()
            {
                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("INSERT INTO [dbo].[Farm] ([Name]) VALUES (" + Name + ")");

                return ID;
            }
            public string Update()
            {
                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("UPDATE [dbo].[Farm] SET [Name] = " + Name + " WHERE ID = " + ID);

                return id;
            }
            public string Delete()
            {
                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("DELETE FROM [dbo].[Farm] WHERE ID = " + ID);

                return d;
            }
        }

        public struct Open
        {
            #region var
            public int nav { get; set; }
            public int ID { get; set; }
            public int JorID { get; set; }
            public DateTime Date { get; set; }
            public string Notes { get; set; }
            public int UserID { get; set; }
            public DataTable IO { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nav", SqlDbType.Int);
                param[0].Value = @nav;

                param[1] = new SqlParameter("@ID", SqlDbType.Int);
                param[1].Value = @ID;

                st = dal.Select_Multi("Open_Select", param);
                return st;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[1].Value = Notes;

                param[2] = new SqlParameter("@UserID", SqlDbType.Int);
                param[2].Value = UserID;

                param[3] = new SqlParameter("@IO", SqlDbType.Structured);
                param[3].Value = IO;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Open_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[2].Value = Notes;

                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = UserID;

                param[4] = new SqlParameter("@IO", SqlDbType.Structured);
                param[4].Value = IO;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Open_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Open_Delete", param);

                return d;
            }
        }
        public struct ItemsEdit
        {
            #region var
            public int nav { get; set; }
            public int ID { get; set; }
            public int JorID { get; set; }
            public DateTime Date { get; set; }
            public string Notes { get; set; }
            public int UserID { get; set; }
            public DataTable IO { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nav", SqlDbType.Int);
                param[0].Value = @nav;

                param[1] = new SqlParameter("@ID", SqlDbType.Int);
                param[1].Value = @ID;

                st = dal.Select_Multi("ItemsEdit_Select", param);
                return st;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[1].Value = Notes;

                param[2] = new SqlParameter("@UserID", SqlDbType.Int);
                param[2].Value = UserID;

                param[3] = new SqlParameter("@IO", SqlDbType.Structured);
                param[3].Value = IO;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("ItemsEdit_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[2].Value = Notes;

                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = UserID;

                param[4] = new SqlParameter("@IO", SqlDbType.Structured);
                param[4].Value = IO;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("ItemsEdit_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("ItemsEdit_Delete", param);

                return d;
            }
        }

        public struct ST
        {
            public string ID;
            public string date_From;
            public string date_To;

            public DataTable Select()
            {
                string where = "\r\nWHERE ";
                string where_open = "\r\nWHERE ";
                where += (ID != "-1") ? "ACCID = '" + ID + "'" : "";
                where_open += (ID != "-1") ? "ACCID = '" + ID + "'" : "";
                where += (date_From != "01/01/1753") ? " and Date >= CONVERT(datetime,'" + date_From + "', 103)" : "";
                where_open += (date_From != "01/01/1753") ? " and Date < CONVERT(datetime,'" + date_From + "', 103)" : " and Date < '01/01/1753'";
                where += (date_To != "12/31/9998") ? " and Date <=  CONVERT(datetime,'" + date_To + "', 103)" : "";

                if (where == "\r\nWHERE ") { where = ""; }

                string open = "SELECT "
                + "sum([Debit]) as Debit, "
                + "sum([Credit]) as Credit,"
                + "'رصيد إفتتاحي' as Notes,"
                + "null as JorID,"
                + "null as Date,"
                + "null as RefTypeName,"
                + "null as RefID"
                + " FROM[dbo].[V_St]"
                + where_open + " union all ";

                string s = open
                + "SELECT  [Debit]"
                + ",[Credit]"
                + ",[Notes]"
                + ",[JorID]"
                + ",[Date]"
                + ",[RefTypeName]"
                + ",[RefID]"
                + "FROM[Farm].[dbo].[V_ST]"
                + where;

                DAL.DAL dal = new DAL.DAL();
                DataTable dt_St = new DataTable();

                dt_St = dal.Select(s);

                return dt_St;
            }
        }
        public struct TB
        {
            public string aCC_ID;
            public string date_From;
            public string date_To;
            public string Branche;
            public string CC1;
            public string CC2;
            public string Level;

            public DataTable View_TB_Select()
            {
                string where = "WHERE ";
                where += (aCC_ID != "-1") ? "ParentID = '" + aCC_ID + "' " : "";
                where += (date_From != "01/01/1753") ? "and [Date] >= '" + date_From + "' " : "";
                where += (date_To != "12/31/9998") ? "and [Date] <= '" + date_To + "' " : "";
                where += (Branche != "-1") ? "and (Branche_ID = '" + Branche + "' or Branche_ID is null)" : "";
                where += (CC1 != "-1") ? "and CC1_ID LIKE '" + CC1 + "%'" : "";
                where += (CC2 != "-1") ? "and CC2_ID LIKE '" + CC2 + "%'" : "";
                where += "and [level] <= " + Level;

                // if after Where is "and"
                if (where.Length >= 9)
                {
                    if (where.Substring(6, 3) == "and")
                    {
                        where = where.Substring(0, 6) + where.Substring(9);
                    }
                }

                if (where == "WHERE ")
                { where = ""; }

                string s = "SELECT "
       + "[ID]"
       + ",[Name]"
       + ", isnull(sum(CASE WHEN [Date] < '" + date_From + "' or Parent = 1 THEN[Debit] ELSE 0 END),0) AS Open_Debit"
       + ", isnull(sum(CASE WHEN [Date] < '" + date_From + "' or Parent = 1 THEN[Credit] ELSE 0 END),0) AS Open_Credit"
       + ", isnull(sum(CASE WHEN [Date] >= '" + date_From + "' or Parent = 1 THEN[Debit] ELSE 0 END),0) AS Debit"
       + ", isnull(sum(CASE WHEN [Date] >= '" + date_From + "' or Parent = 1 THEN[Credit] ELSE 0 END),0) AS Credit,"
       + " max(CAST(Parent as int)) AS Parent"
       + " FROM TB_Select() " + where
       + " group by ID,Name "
       + " order by ID ";


                DAL.DAL DAL = new DAL.DAL();
                DataTable dt = new DataTable();
                DataTable dt_TB = new DataTable();
                dt = DAL.Select(s);
                dt_TB = dt.Clone();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dt.Rows[i]["Parent"]) == true)
                    {
                        string parent_id = dt.Rows[i]["ID"].ToString();
                        dt_TB.Rows.Add(dt.Rows[i].ItemArray);
                        dt.Rows.RemoveAt(i);
                        i--;
                        for (int p = (i < 0) ? 0 : i; p < dt.Rows.Count - 1; p++)
                        {
                            if (dt.Rows[p]["ID"].ToString().StartsWith(parent_id))
                            {
                                dt_TB.Rows.Add(dt.Rows[p].ItemArray);
                                dt.Rows.RemoveAt(p);
                                p--;
                            }
                            else
                            {

                            }
                        }
                    }
                }

                return dt_TB;
            }
        }
        public struct SW
        {
            #region var
            public int nav { get; set; }
            public string ID { get; set; }
            public DateTime Date { get; set; }
            public string Items2ID { get; set; }
            public decimal Quan { get; set; }
            public string ItemsID { get; set; }
            public int CatID { get; set; }
            public int FarmID { get; set; }
            public int TypeID { get; set; }
            public string Notes { get; set; }
            public int UserID { get; set; }
            public DataTable SWD { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nav", SqlDbType.Int);
                param[0].Value = nav;

                param[1] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[1].Value = ID;

                st = dal.Select_Multi("SW_Select", param);
                return st;
            }
            public DataSet Select(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                st = dal.Select_Multi(s);
                return st;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@Items2ID", SqlDbType.VarChar, 50);
                param[1].Value = Items2ID;

                param[2] = new SqlParameter("@Quan", SqlDbType.Decimal);
                param[2].Value = Quan;

                param[3] = new SqlParameter("@ItemsID", SqlDbType.VarChar, 50);
                param[3].Value = ItemsID;

                param[4] = new SqlParameter("@CatID", SqlDbType.Int);
                param[4].Value = CatID;

                param[5] = new SqlParameter("@FarmID", SqlDbType.Int);
                param[5].Value = FarmID;

                param[6] = new SqlParameter("@TypeID", SqlDbType.Int);
                param[6].Value = TypeID;

                param[7] = new SqlParameter("@Notes", SqlDbType.NVarChar, 100);
                param[7].Value = Notes;

                param[8] = new SqlParameter("@UserID", SqlDbType.Int);
                param[8].Value = UserID;

                param[9] = new SqlParameter("@SWD", SqlDbType.Structured);
                param[9].Value = SWD;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("SW_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[11];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@Items2ID", SqlDbType.VarChar, 50);
                param[2].Value = Items2ID;

                param[3] = new SqlParameter("@Quan", SqlDbType.Decimal);
                param[3].Value = Quan;

                param[4] = new SqlParameter("@ItemsID", SqlDbType.VarChar, 50);
                param[4].Value = ItemsID;

                param[5] = new SqlParameter("@CatID", SqlDbType.Int);
                param[5].Value = CatID;

                param[6] = new SqlParameter("@FarmID", SqlDbType.Int);
                param[6].Value = FarmID;

                param[7] = new SqlParameter("@TypeID", SqlDbType.Int);
                param[7].Value = TypeID;

                param[8] = new SqlParameter("@Notes", SqlDbType.NVarChar, 100);
                param[8].Value = Notes;

                param[9] = new SqlParameter("@UserID", SqlDbType.Int);
                param[9].Value = UserID;

                param[10] = new SqlParameter("@SWD", SqlDbType.Structured);
                param[10].Value = SWD;


                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("SW_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("SW_Delete", param);

                return d;
            }
        }

        public struct Tat3eem
        {
            #region var
            public int nav { get; set; }
            public string ID { get; set; }
            public DateTime Date { get; set; }
            public string Notes { get; set; }
            public int UserID { get; set; }
            public DataTable Tat3eemD { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nav", SqlDbType.Int);
                param[0].Value = nav;

                param[1] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[1].Value = ID;

                st = dal.Select_Multi("Tat3eem_Select", param);
                return st;
            }
            public DataSet Select(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                st = dal.Select_Multi(s);
                return st;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@Notes", SqlDbType.NVarChar, 100);
                param[1].Value = Notes;

                param[2] = new SqlParameter("@UserID", SqlDbType.Int);
                param[2].Value = UserID;

                param[3] = new SqlParameter("@Tat3eemD", SqlDbType.Structured);
                param[3].Value = Tat3eemD;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Tat3eem_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@Notes", SqlDbType.NVarChar, 100);
                param[2].Value = Notes;

                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = UserID;

                param[4] = new SqlParameter("@Tat3eemD", SqlDbType.Structured);
                param[4].Value = Tat3eemD;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Tat3eem_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Tat3eem_Delete", param);

                return d;
            }
        }
        public struct AlarmSet
        {
            #region var
            public int ID { get; set; }
            public string Name { get; set; }
            public bool WithoutItem { get; set; }
            public string Items2ID { get; set; }
            public int CatID { get; set; }
            public bool StartBDate { get; set; }
            public int StartDayBDate { get; set; }
            public string Notes { get; set; }
            public decimal Quan { get; set; }
            public bool WhenInsert { get; set; }
            public bool Other { get; set; }
            public DataTable dt_AlarmOther { get; set; }

            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet ds = new DataSet();

                ds = dal.Select_Multi("AlarmSet_Select", null);
                return ds;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[11];

                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[0].Value = Name;

                param[1] = new SqlParameter("@WithoutItem", SqlDbType.Bit);
                param[1].Value = WithoutItem;

                param[2] = new SqlParameter("@CatID", SqlDbType.Int);
                param[2].Value = CatID;

                param[3] = new SqlParameter("@Items2ID", SqlDbType.VarChar, 50);
                param[3].Value = Items2ID;

                param[4] = new SqlParameter("@Quan", SqlDbType.Decimal);
                param[4].Value = Quan;

                param[5] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[5].Value = Notes;

                param[6] = new SqlParameter("@WhenInsert", SqlDbType.Bit);
                param[6].Value = WhenInsert;

                param[7] = new SqlParameter("@StartBDate", SqlDbType.Bit);
                param[7].Value = StartBDate;

                param[8] = new SqlParameter("@StartDayBDate", SqlDbType.Int);
                param[8].Value = StartDayBDate;

                param[9] = new SqlParameter("@Other", SqlDbType.Bit);
                param[9].Value = Other;

                param[10] = new SqlParameter("@dt_AlarmOther", SqlDbType.Structured);
                param[10].Value = dt_AlarmOther;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("AlarmSet_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[12];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
                param[1].Value = Name;

                param[2] = new SqlParameter("@WithoutItem", SqlDbType.Bit);
                param[2].Value = WithoutItem;

                param[3] = new SqlParameter("@CatID", SqlDbType.Int);
                param[3].Value = CatID;

                param[4] = new SqlParameter("@Items2ID", SqlDbType.VarChar, 50);
                param[4].Value = Items2ID;

                param[5] = new SqlParameter("@Quan", SqlDbType.Decimal);
                param[5].Value = Quan;

                param[6] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[6].Value = Notes;

                param[7] = new SqlParameter("@WhenInsert", SqlDbType.Bit);
                param[7].Value = WhenInsert;

                param[8] = new SqlParameter("@StartBDate", SqlDbType.Bit);
                param[8].Value = StartBDate;

                param[9] = new SqlParameter("@StartDayBDate", SqlDbType.Int);
                param[9].Value = StartDayBDate;

                param[10] = new SqlParameter("@Other", SqlDbType.Bit);
                param[10].Value = Other;

                param[11] = new SqlParameter("@dt_AlarmOther", SqlDbType.Structured);
                param[11].Value = dt_AlarmOther;


                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("AlarmSet_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("AlarmSet_Delete", param);

                return d;
            }
        }

        public struct Pur
        {
            #region var
            public int nav { get; set; }
            public string ID { get; set; }
            public int JorID { get; set; }
            public DateTime Date { get; set; }
            public int PayTypeID { get; set; }
            public string VenID { get; set; }
            public string VenDocID { get; set; }
            public string Notes { get; set; }
            public decimal TotalPPrice { get; set; }
            public decimal DisVal { get; set; }
            public decimal Net { get; set; }
            public int UserID { get; set; }
            public DataTable IO { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nav", SqlDbType.Int);
                param[0].Value = nav;

                param[1] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[1].Value = ID;

                st = dal.Select_Multi("Pur_Select", param);
                return st;
            }
            public DataSet Select(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                st = dal.Select_Multi(s);
                return st;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[1].Value = PayTypeID;

                param[2] = new SqlParameter("@VenID", SqlDbType.VarChar, 50);
                param[2].Value = VenID;

                param[3] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[3].Value = Notes;

                param[4] = new SqlParameter("@UserID", SqlDbType.Int);
                param[4].Value = UserID;

                param[5] = new SqlParameter("@TotalPPrice", SqlDbType.Decimal);
                param[5].Value = TotalPPrice;

                param[6] = new SqlParameter("@DisVal", SqlDbType.Decimal);
                param[6].Value = DisVal;

                param[7] = new SqlParameter("@Net", SqlDbType.Decimal);
                param[7].Value = Net;

                param[8] = new SqlParameter("@IO", SqlDbType.Structured);
                param[8].Value = IO;

                param[9] = new SqlParameter("@VenDocID", SqlDbType.VarChar, 50);
                param[9].Value = VenDocID;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Pur_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[11];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[2].Value = PayTypeID;

                param[3] = new SqlParameter("@VenID", SqlDbType.VarChar, 50);
                param[3].Value = VenID;

                param[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[4].Value = Notes;

                param[5] = new SqlParameter("@UserID", SqlDbType.Int);
                param[5].Value = UserID;

                param[6] = new SqlParameter("@TotalPPrice", SqlDbType.Decimal);
                param[6].Value = TotalPPrice;

                param[7] = new SqlParameter("@DisVal", SqlDbType.Decimal);
                param[7].Value = DisVal;

                param[8] = new SqlParameter("@Net", SqlDbType.Decimal);
                param[8].Value = Net;

                param[9] = new SqlParameter("@IO", SqlDbType.Structured);
                param[9].Value = IO;

                param[10] = new SqlParameter("@VenDocID", SqlDbType.VarChar, 50);
                param[10].Value = VenDocID;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Pur_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Pur_Delete", param);

                return d;
            }
        }

        public struct Pre
        {
            #region var
            public int nav { get; set; }
            public string ID { get; set; }
            public int JorID { get; set; }
            public DateTime Date { get; set; }
            public int PayTypeID { get; set; }
            public string VenID { get; set; }
            public string VenDocID { get; set; }
            public string Notes { get; set; }
            public decimal TotalPPrice { get; set; }
            public decimal DisVal { get; set; }
            public decimal Net { get; set; }
            public int UserID { get; set; }
            public DataTable IO { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nav", SqlDbType.Int);
                param[0].Value = nav;

                param[1] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[1].Value = ID;

                st = dal.Select_Multi("Pre_Select", param);
                return st;
            }
            public DataSet Select(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                st = dal.Select_Multi(s);
                return st;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[1].Value = PayTypeID;

                param[2] = new SqlParameter("@VenID", SqlDbType.VarChar, 50);
                param[2].Value = VenID;

                param[3] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[3].Value = Notes;

                param[4] = new SqlParameter("@UserID", SqlDbType.Int);
                param[4].Value = UserID;

                param[5] = new SqlParameter("@TotalPPrice", SqlDbType.Decimal);
                param[5].Value = TotalPPrice;

                param[6] = new SqlParameter("@DisVal", SqlDbType.Decimal);
                param[6].Value = DisVal;

                param[7] = new SqlParameter("@Net", SqlDbType.Decimal);
                param[7].Value = Net;

                param[8] = new SqlParameter("@IO", SqlDbType.Structured);
                param[8].Value = IO;

                param[9] = new SqlParameter("@VenDocID", SqlDbType.VarChar, 50);
                param[9].Value = VenDocID;

                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Pre_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[11];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[2].Value = PayTypeID;

                param[3] = new SqlParameter("@VenID", SqlDbType.VarChar, 50);
                param[3].Value = VenID;

                param[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[4].Value = Notes;

                param[5] = new SqlParameter("@UserID", SqlDbType.Int);
                param[5].Value = UserID;

                param[6] = new SqlParameter("@TotalPPrice", SqlDbType.Decimal);
                param[6].Value = TotalPPrice;

                param[7] = new SqlParameter("@DisVal", SqlDbType.Decimal);
                param[7].Value = DisVal;

                param[8] = new SqlParameter("@Net", SqlDbType.Decimal);
                param[8].Value = Net;

                param[9] = new SqlParameter("@IO", SqlDbType.Structured);
                param[9].Value = IO;

                param[10] = new SqlParameter("@VenDocID", SqlDbType.VarChar, 50);
                param[10].Value = VenDocID;

                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Pre_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Pre_Delete", param);

                return d;
            }
        }

        public struct Sal
        {
            #region var
            public int nav { get; set; }
            public string ID { get; set; }
            public int JorID { get; set; }
            public DateTime Date { get; set; }
            public int PayTypeID { get; set; }
            public string CustID { get; set; }
            public string Notes { get; set; }
            public decimal TotalSPrice { get; set; }
            public decimal DisVal { get; set; }
            public decimal Net { get; set; }
            public int UserID { get; set; }
            public DataTable IO { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nav", SqlDbType.Int);
                param[0].Value = nav;

                param[1] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[1].Value = ID;

                st = dal.Select_Multi("Sal_Select", param);
                return st;
            }
            public DataSet Select(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                st = dal.Select_Multi(s);
                return st;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[9];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[1].Value = PayTypeID;

                param[2] = new SqlParameter("@CustID", SqlDbType.VarChar, 50);
                param[2].Value = CustID;

                param[3] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[3].Value = Notes;

                param[4] = new SqlParameter("@UserID", SqlDbType.Int);
                param[4].Value = UserID;

                param[5] = new SqlParameter("@TotalSPrice", SqlDbType.Decimal);
                param[5].Value = TotalSPrice;

                param[6] = new SqlParameter("@DisVal", SqlDbType.Decimal);
                param[6].Value = DisVal;

                param[7] = new SqlParameter("@Net", SqlDbType.Decimal);
                param[7].Value = Net;

                param[8] = new SqlParameter("@IO", SqlDbType.Structured);
                param[8].Value = IO;


                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Sal_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[2].Value = PayTypeID;

                param[3] = new SqlParameter("@CustID", SqlDbType.VarChar, 50);
                param[3].Value = CustID;

                param[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[4].Value = Notes;

                param[5] = new SqlParameter("@UserID", SqlDbType.Int);
                param[5].Value = UserID;

                param[6] = new SqlParameter("@TotalSPrice", SqlDbType.Decimal);
                param[6].Value = TotalSPrice;

                param[7] = new SqlParameter("@DisVal", SqlDbType.Decimal);
                param[7].Value = DisVal;

                param[8] = new SqlParameter("@Net", SqlDbType.Decimal);
                param[8].Value = Net;

                param[9] = new SqlParameter("@IO", SqlDbType.Structured);
                param[9].Value = IO;


                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Sal_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Sal_Delete", param);

                return d;
            }
        }

        public struct Sre
        {
            #region var
            public int nav { get; set; }
            public string ID { get; set; }
            public int JorID { get; set; }
            public DateTime Date { get; set; }
            public int PayTypeID { get; set; }
            public string CustID { get; set; }
            public string Notes { get; set; }
            public decimal TotalSPrice { get; set; }
            public decimal DisVal { get; set; }
            public decimal Net { get; set; }
            public int UserID { get; set; }
            public DataTable IO { get; set; }
            #endregion

            public DataSet Select()
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nav", SqlDbType.Int);
                param[0].Value = nav;

                param[1] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[1].Value = ID;

                st = dal.Select_Multi("Sre_Select", param);
                return st;
            }
            public DataSet Select(string s)
            {
                DAL.DAL dal = new DAL.DAL();
                DataSet st = new DataSet();

                st = dal.Select_Multi(s);
                return st;
            }
            public string Insert()
            {
                SqlParameter[] param = new SqlParameter[9];

                param[0] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[0].Value = Date;

                param[1] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[1].Value = PayTypeID;

                param[2] = new SqlParameter("@CustID", SqlDbType.VarChar, 50);
                param[2].Value = CustID;

                param[3] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[3].Value = Notes;

                param[4] = new SqlParameter("@UserID", SqlDbType.Int);
                param[4].Value = UserID;

                param[5] = new SqlParameter("@TotalSPrice", SqlDbType.Decimal);
                param[5].Value = TotalSPrice;

                param[6] = new SqlParameter("@DisVal", SqlDbType.Decimal);
                param[6].Value = DisVal;

                param[7] = new SqlParameter("@Net", SqlDbType.Decimal);
                param[7].Value = Net;

                param[8] = new SqlParameter("@IO", SqlDbType.Structured);
                param[8].Value = IO;


                DAL.DAL dal = new DAL.DAL();
                string ID;
                ID = dal.ExecuteCommand("Sre_Insert", param);

                return ID;
            }
            public string Update()
            {
                SqlParameter[] param = new SqlParameter[10];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
                param[1].Value = Date;

                param[2] = new SqlParameter("@DocPayTypeID", SqlDbType.Int);
                param[2].Value = PayTypeID;

                param[3] = new SqlParameter("@CustID", SqlDbType.VarChar, 50);
                param[3].Value = CustID;

                param[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 100);
                param[4].Value = Notes;

                param[5] = new SqlParameter("@UserID", SqlDbType.Int);
                param[5].Value = UserID;

                param[6] = new SqlParameter("@TotalSPrice", SqlDbType.Decimal);
                param[6].Value = TotalSPrice;

                param[7] = new SqlParameter("@DisVal", SqlDbType.Decimal);
                param[7].Value = DisVal;

                param[8] = new SqlParameter("@Net", SqlDbType.Decimal);
                param[8].Value = Net;

                param[9] = new SqlParameter("@IO", SqlDbType.Structured);
                param[9].Value = IO;


                DAL.DAL dal = new DAL.DAL();
                string id;
                id = dal.ExecuteCommand("Sre_Update", param);

                return id;
            }
            public string Delete()
            {
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 10);
                param[0].Value = ID;

                DAL.DAL dal = new DAL.DAL();
                string d;
                d = dal.ExecuteCommand("Sre_Delete", param);

                return d;
            }
        }
        #endregion

        public struct Rep
        {
            #region var
            public int Rep_ID;
            public string Name;
            public string Content;
            public int Row_Count;
            public bool Row_Index;
            public int Font_Size;
            public string Rep_View;
            public int User_ID;
            public DataTable RepD;
            #endregion

            public DataTable Select(string txt)
            {
                DAL.DAL dal = new DAL.DAL();

                DataTable rep = new DataTable();
                rep = dal.Select(txt);

                return rep;
            }
            public DataTable Select_Rep_Info(string Column_Name, string Data_Type)
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@Column_Name", SqlDbType.NVarChar, 30);
                param[0].Value = Column_Name;

                param[1] = new SqlParameter("@Data_Type", SqlDbType.VarChar, 10);
                param[1].Value = Data_Type;

                DataTable rep = new DataTable();
                rep = dal.Select("Rep_Info", param);

                return rep;
            }

            public string Insert()
            {
                DAL.DAL dal = new DAL.DAL();

                SqlParameter[] param = new SqlParameter[8];

                param[0] = new SqlParameter("@Rep_Name", SqlDbType.NVarChar, 50);
                param[0].Value = Name;

                param[1] = new SqlParameter("@Content", SqlDbType.NVarChar, 500);
                param[1].Value = Content;

                param[2] = new SqlParameter("@Row_Count", SqlDbType.Int);
                param[2].Value = Row_Count;

                param[3] = new SqlParameter("@Row_Index", SqlDbType.Bit);
                param[3].Value = Row_Index;

                param[4] = new SqlParameter("@Font_Size", SqlDbType.Int);
                param[4].Value = Font_Size;

                param[5] = new SqlParameter("@Rep_View", SqlDbType.NVarChar, 15);
                param[5].Value = Rep_View;

                param[6] = new SqlParameter("@User_ID", SqlDbType.Int);
                param[6].Value = User_ID;

                param[7] = new SqlParameter("@RepD", SqlDbType.Structured);
                param[7].Value = RepD;

                string F;
                F = dal.ExecuteCommand("Rep_Insert", param);

                return F;
            }
            public DataTable Select_Rep(string Rep_Name)
            {
                DAL.DAL dal = new DAL.DAL();

                DataTable rep = new DataTable();
                rep = dal.Select(Rep_Name);

                return rep;
            }
            public string Delete()
            {
                DAL.DAL dal = new DAL.DAL();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@RepID", SqlDbType.Int);
                param[0].Value = Rep_ID;

                string F;
                F = dal.ExecuteCommand("Rep_Delete", param);

                return F;
            }
        }
    }
}
