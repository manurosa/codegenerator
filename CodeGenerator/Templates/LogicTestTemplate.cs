﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class LogicTestTemplate : TestTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using DAL;\r\nusing Entities;\r\nusing Logic;\r\nusing Moq;\r\nusing NUnit.Framework;\r\nus" +
                    "ing System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System" +
                    ".Text;\r\nusing System.Threading.Tasks;\r\n\r\nnamespace Logic_Tests\r\n{\r\n");
            
            #line 19 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
    var ObjectData = templateData.ObjectData;
    var InsertProcedureTemplate = templateData.ProcedureDataList["PR_INSERT"];
 
            
            #line default
            #line hidden
            this.Write("    [TestFixture]\r\n[Category(\"");
            
            #line 23 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("Logic\")]\r\n    public class ");
            
            #line 24 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("LogicTests\r\n    {\r\n        private Mock<IDAL<");
            
            #line 26 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">> ");
            
            #line 26 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL;\r\n\r\n        public ");
            
            #line 28 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(" TestEntity = new ");
            
            #line 28 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n");
            
            #line 30 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
    PushIndent("\t\t\t\t");
    foreach (var field in ObjectData) {  
        WriteLine("{0} = {1},", field.PropertyName, TestValueForPropertyType[field.Type]);      
    }
    PopIndent(); 
            
            #line default
            #line hidden
            this.Write("    \r\n        };\r\n\r\n        public List<");
            
            #line 37 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write("> TestEntityList = new List<");
            
            #line 37 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">();\r\n\r\n        [SetUp]\r\n        public virtual void Setup()\r\n        {\r\n        " +
                    "    ");
            
            #line 42 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL = new Mock<IDAL<");
            
            #line 42 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">>();\r\n            \r\n            TestEntityList.Add(TestEntity);\r\n\r\n            ");
            
            #line 46 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.Get(It.IsAny<Int32>())).Returns(new ");
            
            #line 46 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write("());\r\n            ");
            
            #line 47 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.GetAll()).Returns(new List<");
            
            #line 47 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">());\r\n            ");
            
            #line 48 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.Save(TestEntity)).Returns(0);\r\n            ");
            
            #line 49 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.Update(It.IsAny<");
            
            #line 49 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">()));\r\n            ");
            
            #line 50 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.Delete(It.IsAny<Int32>()));\r\n        }\r\n");
            
            #line 52 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
    var outParam = InsertProcedureTemplate.OutParam; 
            
            #line default
            #line hidden
            this.Write("\r\n        [Test()]\r\n        public void  Test_Get_Exists_ReturnsEntity()\r\n       " +
                    " {\r\n            ");
            
            #line 57 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.Get(TestEntity.");
            
            #line 57 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(")).Returns(TestEntity);\r\n            var logic = new LogicFactory().Create<");
            
            #line 58 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 58 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Object);\r\n\r\n\t\t\tvar actual = logic.Get(TestEntity.");
            
            #line 60 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n            \r\n            Assert.AreEqual(TestEntity.");
            
            #line 62 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(", actual.");
            
            #line 62 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t");
            
            #line 63 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Verify(x => x.Get(TestEntity.");
            
            #line 63 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write("), Times.Once);\r\n        }\r\n\r\n        [Test()]\r\n        public void Test_Get_NonE" +
                    "xists_ReturnsEmptyEntity()\r\n        {\r\n\t\t\tvar logic = new LogicFactory().Create<" +
                    "");
            
            #line 69 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 69 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Object);\r\n\r\n\t\t\tvar actual = logic.Get(TestEntity.");
            
            #line 71 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n\t\t\tAssert.AreEqual(0, actual.");
            
            #line 73 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t");
            
            #line 74 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Verify(x => x.Get(TestEntity.");
            
            #line 74 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write("), Times.Once);\r\n        }\r\n\r\n        [Test()]\r\n        public void Test_GetAll_E" +
                    "xists_ReturnsEntities()\r\n        {\r\n            ");
            
            #line 80 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.GetAll()).Returns(TestEntityList);\r\n            var logic = new " +
                    "LogicFactory().Create<");
            
            #line 81 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 81 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Object);\r\n\r\n\t\t\tvar actual = logic.GetAll();\r\n\r\n\t\t\tAssert.AreEqual(TestEntityL" +
                    "ist, actual);            \r\n            ");
            
            #line 86 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Verify(x => x.GetAll(), Times.Once);\r\n        }\r\n\r\n        [Test()]\r\n        " +
                    "public void Test_GetAll_NonExists_ReturnsEmptyList()\r\n        {\r\n\t\t\tvar logic = " +
                    "new LogicFactory().Create<");
            
            #line 92 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 92 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Object);\r\n\r\n\t\t\tvar actual = logic.GetAll();\r\n\r\n            Assert.AreEqual(ne" +
                    "w List<");
            
            #line 96 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">(), actual);\r\n            ");
            
            #line 97 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Verify(x => x.GetAll(), Times.Once);\r\n        }\r\n\r\n        [Test()]\r\n        " +
                    "public void Test_Save_Insert_ReturnsId()\r\n        {\r\n\t\t\tvar saveEntity = new ");
            
            #line 103 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write("();\r\n            ");
            
            #line 104 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.Save(saveEntity)).Returns(TestEntity.");
            
            #line 104 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n            var logic = new LogicFactory().Create<");
            
            #line 105 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 105 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Object);\r\n\r\n            var actual = logic.Save(saveEntity);\r\n\r\n            A" +
                    "ssert.AreEqual(TestEntity.");
            
            #line 109 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(", actual);\r\n            ");
            
            #line 110 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Verify(x => x.Save(saveEntity), Times.Once);\r\n        }\r\n\r\n        [Test()]\r\n" +
                    "        public void Test_Save_Update_ReturnsId()\r\n        {\r\n            ");
            
            #line 116 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.Update(TestEntity)).Returns(TestEntity.");
            
            #line 116 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n            var logic = new LogicFactory().Create<");
            
            #line 117 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 117 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Object);\r\n\r\n            var actual = logic.Save(TestEntity);\r\n\r\n            A" +
                    "ssert.AreEqual(TestEntity.");
            
            #line 121 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(", actual);\r\n            ");
            
            #line 122 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Verify(x => x.Update(TestEntity), Times.Once);\r\n        }\r\n\r\n        [Test]\r\n" +
                    "        public void Test_Delete_Id()\r\n        {\r\n            ");
            
            #line 128 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Setup(r => r.Delete(TestEntity.Id));\r\n            var logic = new LogicFactor" +
                    "y().Create<");
            
            #line 129 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.EntityName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 129 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Object);\r\n\r\n            logic.Delete(TestEntity.");
            
            #line 131 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n            ");
            
            #line 133 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectData.ObjectName));
            
            #line default
            #line hidden
            this.Write("DAL.Verify(x => x.Delete(TestEntity.");
            
            #line 133 "C:\Users\Diego\Source\Repos\micase-codegenerator\CodeGenerator\Templates\LogicTestTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outParam.PropertyName));
            
            #line default
            #line hidden
            this.Write("), Times.Once);\r\n        }\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
