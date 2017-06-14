using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NINumberValidator.Test
{
    [TestClass]
    public class NIValidatorTests
    {
        //1. Must be 9 characters in length
        [TestMethod]
        public void Given_A_String_Longer_Than_9_Characters_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456AB");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_A_String_Less_Than_9_Characters_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_An_Empty_String_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_A_Null_Value_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_A_String_Which_is_9_Characters_Long_Should_Return_True()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456A");
            Assert.IsTrue(result);
        }

        //2. First 2 characters must be alpa	
        [TestMethod]
        public void Given_First_2_Characters_Are_Numeric_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("00123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Character_Is_Numeric_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("0J123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Second_Character_Is_Numeric_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("J0123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Two_Characters_Are_Alpha_Should_Return_True()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456A");
            Assert.IsTrue(result);
        }

        //3. Next 6 characters must be numeric
        [TestMethod]
        public void Given_Next_6_Characters_Are_Numeric_Should_Return_True()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456A");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Given_First_Of_Next_6_Characters_Are_Not_Numeric_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJJ23456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_All_Next_6_Characters_Are_Not_Numeric_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJJJJJJJA");
            Assert.IsFalse(result);
        }

        //4. Final character can be A, B, C or D.
        [TestMethod]
        public void Given_Final_Character_Is_A_Should_Return_True()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456A");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Given_Final_Character_Is_B_Should_Return_True()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456B");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Given_Final_Character_Is_C_Should_Return_True()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456C");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Given_Final_Character_Is_D_Should_Return_True()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456D");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Given_Final_Character_Is_E_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456E");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Final_Character_Is_Z_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JJ123456Z");
            Assert.IsFalse(result);
        }

        //5. First character must not be D, F, I, Q, U or V.
        [TestMethod]
        public void Given_First_Character_Is_D_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("DJ123456D");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Character_Is_F_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("FJ123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Character_Is_I_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("IJ123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Character_Is_Q_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("QJ123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Character_Is_U_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("UJ123456C");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Character_Is_V_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("VJ123456C");
            Assert.IsFalse(result);
        }

        //6. Second character must not be D, F, I, O, Q, U or V.
        [TestMethod]
        public void Given_Second_Character_Is_D_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JD123456D");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Second_Character_Is_F_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JF123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Second_Character_Is_I_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JI123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Second_Character_Is_O_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JO123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Second_Character_Is_Q_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JQ123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Second_Character_Is_U_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JU123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Second_Character_Is_V_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("JV123456A");
            Assert.IsFalse(result);
        }

        //7. The first 2 characters must not be combinations of GB, NK, TN or ZZ(the term combination covers GB and BG etc).
        [TestMethod]
        public void Given_First_Two_Characters_Are_GB_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("GB123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Two_Characters_Are_BG_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("BG123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Two_Characters_Are_NK_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("NK123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Two_Characters_Are_KN_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("KN123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Two_Characters_Are_TN_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("TN123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Two_Characters_Are_NT_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("NT123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Two_Characters_Are_ZZ_Should_Return_False()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("ZZ123456A");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_First_Two_Characters_Are_Allowed_Should_Return_True()
        {
            NIValidator validator = new NIValidator();
            bool result = validator.IsValid("HG123456A");
            Assert.IsTrue(result);
        }
    }
}