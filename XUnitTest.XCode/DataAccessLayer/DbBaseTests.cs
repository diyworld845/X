﻿using System;
using NewLife.Model;
using XCode.DataAccessLayer;
using Xunit;

namespace XUnitTest.XCode.DataAccessLayer
{
    public class DbBaseTests
    {
        static DbBaseTests()
        {
            DAL.WriteLog("Init DAL");
        }

        [Theory]
        [InlineData("Name", "name")]
        [InlineData("NickName", "nick_name")]
        [InlineData("ID", "id")]
        [InlineData("ProductID", "product_id")]
        [InlineData("CreateIP", "create_ip")]
        [InlineData("IPStart", "ip_start")]
        [InlineData("RoleID", "role_id")]
        [InlineData("RoleIds", "role_ids")]
        [InlineData("LastLoginIP", "last_login_ip")]
        public void FormatUnderlineName(String name, String result)
        {
            var table = ObjectContainer.Current.Resolve<IDataTable>();
            table.TableName = name;

            var db = DbFactory.Create(DatabaseType.SQLite);
            db.NameFormat = NameFormats.Underline;

            var rs = db.FormatName(table);
            Assert.Equal(result, rs);
        }
    }
}
