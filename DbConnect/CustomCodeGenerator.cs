using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Migrations.Design;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Utilities;

namespace DbConnect
{
    internal class CustomCodeGenerator : CSharpMigrationCodeGenerator
    {
        //For removal of dbo. during addition of foreign key's convention
        protected override void Generate(AddForeignKeyOperation addForeignKeyOperation, IndentedTextWriter writer)
        {
            addForeignKeyOperation.Name = this.StripDbo(addForeignKeyOperation.Name, addForeignKeyOperation.DependentTable);
            addForeignKeyOperation.Name = this.StripDbo(addForeignKeyOperation.Name, addForeignKeyOperation.PrincipalTable);
            base.Generate(addForeignKeyOperation, writer);
        }

        //For removal of dbo. during addition of foreign key's convention
        protected override void Generate(AddPrimaryKeyOperation addPrimaryKeyOperation, IndentedTextWriter writer)
        {
            addPrimaryKeyOperation.Name = StripDbo(addPrimaryKeyOperation.Name, addPrimaryKeyOperation.Table);
            base.Generate(addPrimaryKeyOperation, writer);
        }

        //For removal of dbo. during drop of foreign key's convention
        protected override void Generate(DropForeignKeyOperation dropForeignKeyOperation, IndentedTextWriter writer)
        {
            dropForeignKeyOperation.Name = this.StripDbo(dropForeignKeyOperation.Name, dropForeignKeyOperation.DependentTable);
            dropForeignKeyOperation.Name = this.StripDbo(dropForeignKeyOperation.Name, dropForeignKeyOperation.PrincipalTable);
            base.Generate(dropForeignKeyOperation, writer);
        }

        //For removal of dbo. during addition of primary key's convention
        protected override void Generate(DropPrimaryKeyOperation dropPrimaryKeyOperation, IndentedTextWriter writer)
        {
            dropPrimaryKeyOperation.Name = StripDbo(dropPrimaryKeyOperation.Name, dropPrimaryKeyOperation.Table);
            base.Generate(dropPrimaryKeyOperation, writer);
        }

        //For removal of dbo. during addition of index's convention
        protected override void Generate(CreateIndexOperation createIndexOperation, IndentedTextWriter writer)
        {
            createIndexOperation.Name = StripDbo(createIndexOperation.Name, createIndexOperation.Table);
            base.Generate(createIndexOperation, writer);
        }

        //For removal of dbo. during drop of index's convention
        protected override void Generate(DropIndexOperation dropIndexOperation, IndentedTextWriter writer)
        {
            dropIndexOperation.Name = StripDbo(dropIndexOperation.Name, dropIndexOperation.Table);
            base.Generate(dropIndexOperation, writer);
        }

        //Strip dbo. from the given name
        private string StripDbo(string objectName, string tableName)
        {
            if (tableName.StartsWith("dbo."))
            {
                return objectName.Replace(tableName, tableName.Substring(4));
            }
            return objectName;
        }
    }
}
