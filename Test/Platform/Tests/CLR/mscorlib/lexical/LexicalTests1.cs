//
//  LexicalTests
//
//  Microsoft Zenith Project
//  Copyright ©2001-2005 Microsoft Corporation
//  One Microsoft Way, Redmond, Washington 98052-6399 U.S.A.
//  All rights reserved.
//  MICROSOFT CONFIDENTIAL
//
//-----------------------------------------------------------------------------

#de\u0066ine endf2

#define \u0066oobar2

#define middle\u0066oobar

#define end\u0066

using System;
using System.Reflection;
using Microsoft.SPOT.Platform.Test;

namespace Microsoft.SPOT.Platform.Tests
{
    public class LexicalTests1 : IMFTestInterface
    {
        [SetUp]
        public InitializeResult Initialize()
        {
            return InitializeResult.ReadyToGo;
        }

        [TearDown]
        public void CleanUp()
        {
            Log.Comment("Cleaning up after the tests");
        }

        //Lexical Test methods
        //The following tests were ported from folder current\test\cases\client\CLR\Conformance\10_classes\Lexical
        //comments_01,comments_02,comments_03,comments_04,comments_05,comments_06,comments_07,comments_10,bool_01,bool_02,int_01,int_02,int_03,int_04,int_05,int_06,intsuffix_01,intsuffix_02,intsuffix_03,intsuffix_04,intsuffix_06,intsuffix_07,suff_typepick_03,real_01,real_02,real_03,real_04,real_05,real_06,char_01,char_02,char_03,realsuffix_01,realsuffix_02,string_01,string_02,string_03,pre_001,pre_004,pre_005,pre_006,pre_008,pre_009,pre_012,pre_013,preproc_03,preproc_04,preproc_05,preproc_06,preproc_07,preproc_09,preproc_15,preproc_16,preproc_17,preproc_18,preproc_19,preproc_20,preproc_21,preproc_22,preproc_23,preproc_24,preproc_25,preproc_30,preproc_31,preproc_32,preproc_38,preproc_39,line_02,line_03,line_06,line_07,line_26,line_35,region_01,region_02,region_05,region_06,region_07,region_10,region_11,region_12,region_15,lineterm_01,atkeyword_03,atkeyword_04,atkeyword_05,ident_01,ident_02,ident_03,ident_04,ident_05,ident_06,ident_07,nullunicode_01,nullunicode_03,nullunicode_04,unicode_02,unicode_04,unicode_05,unicode_06,unicode_07,unicode_08,unicode_09,unicode_10,unicode_11,unicode_12,unicode_13,unicode_17,uni8digit_01,uni8digit_02,uni8digit_03,atstrings_01,atstrings_02,atstrings_03,atstrings_04,mscombo_01,mscombo_05

        //Test Case Calls 
        [TestMethod]
        public MFTestResults Lexical_comments_01_Test()
        {
            Log.Comment("Section 2.4.4 Test");
            Log.Comment("Verifies valid/invalid comment");
            if (Lexical_TestClass_comments_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_comments_02_Test()
        {
            Log.Comment("Section 2.4.4 Test");
            Log.Comment("Verifies valid/invalid comment");
            if (Lexical_TestClass_comments_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_comments_03_Test()
        {
            Log.Comment("Section 2.4.4 Test");
            Log.Comment("Verifies valid/invalid comment");
            if (Lexical_TestClass_comments_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_comments_04_Test()
        {
            Log.Comment("Section 2.4.4 Test");
            Log.Comment("Verifies valid/invalid comment");
            if (Lexical_TestClass_comments_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_comments_05_Test()
        {
            Log.Comment("Section 2.4.4 Test");
            Log.Comment("Verifies valid/invalid comment");
            if (Lexical_TestClass_comments_05.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_comments_06_Test()
        {
            Log.Comment("Section 2.4.4 Test");
            Log.Comment("Verifies valid/invalid comment");
            if (Lexical_TestClass_comments_06.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_comments_07_Test()
        {
            Log.Comment("Section 2.4.4 Test");
            Log.Comment("Verifies valid/invalid comment");
            if (Lexical_TestClass_comments_07.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_comments_10_Test()
        {
            Log.Comment("Section 2.4.4 Test");
            Log.Comment("Verifies valid/invalid comment");
            if (Lexical_TestClass_comments_10.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_bool_01_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify true works on bools");
            if (Lexical_TestClass_bool_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_bool_02_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify false works on bools");
            if (Lexical_TestClass_bool_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_int_01_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify 0 as int literal");
            if (Lexical_TestClass_int_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_int_02_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify positive int literals");
            if (Lexical_TestClass_int_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_int_03_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify negative int literals");
            if (Lexical_TestClass_int_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_int_04_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify negative hex literals");
            if (Lexical_TestClass_int_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_int_05_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify positive hex literals");
            if (Lexical_TestClass_int_05.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_int_06_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify 0 as hex int literal");
            if (Lexical_TestClass_int_06.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_intsuffix_01_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("L/l suffix on longs");
            if (Lexical_TestClass_intsuffix_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_intsuffix_02_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("LU, Ul,uL,ul,LU,Lu,lU,lu suffix on ulongs");
            if (Lexical_TestClass_intsuffix_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_intsuffix_03_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("LU, Ul,uL,ul,LU,Lu,lU,lu suffix on ulongs");
            if (Lexical_TestClass_intsuffix_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_intsuffix_04_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("Verify UL,Ul,uL,ul,LU,Lu,lU,lu suffix are of type ulong");
            if (Lexical_TestClass_intsuffix_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_intsuffix_06_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("Verify L, l suffixes are of type uint");
            if (Lexical_TestClass_intsuffix_06.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_intsuffix_07_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("Using the lowercase 'l' suffix should generate a level 4 warning (VS7:86407)");
            if (Lexical_TestClass_intsuffix_07.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_suff_typepick_03_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("Verify that literals with l, L suffixes are typed according to spec");
            if (Lexical_TestClass_suff_typepick_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_real_01_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify (+/-) double double literals");
            if (Lexical_TestClass_real_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_real_02_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            if (Lexical_TestClass_real_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_real_03_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify (-/+) non-double double literals");
            if (Lexical_TestClass_real_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_real_04_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify E and e (-/+) as double literals");
            if (Lexical_TestClass_real_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_real_05_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify E and e (-/+) as double literals");
            if (Lexical_TestClass_real_05.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_real_06_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify E and e (-/+) as double literals");
            if (Lexical_TestClass_real_06.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_char_01_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify keyboard symbols as chars");
            if (Lexical_TestClass_char_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_char_02_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify all escape sequences in section 2.4.9.4");
            if (Lexical_TestClass_char_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_char_03_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("Hex encoded Unicode characters");
            if (Lexical_TestClass_char_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_realsuffix_01_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("D/d suffix on double literals");
            Log.Comment("Real suffixes");
            if (Lexical_TestClass_realsuffix_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_realsuffix_02_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("F/f suffix on float literals");
            Log.Comment("Real suffixes");
            if (Lexical_TestClass_realsuffix_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_string_01_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify escape sequences in string literals");
            if (Lexical_TestClass_string_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_string_02_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify hex escape sequences in string literals");
            if (Lexical_TestClass_string_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_string_03_Test()
        {
            Log.Comment("Section 2.4.9 Test");
            Log.Comment("verify null strings work");
            if (Lexical_TestClass_string_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_pre_001_Test()
        {
            Log.Comment("Section 2.3Preprocessing");
            Log.Comment("simple pre processor");
            if (Lexical_TestClass_pre_001.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_pre_004_Test()
        {
            Log.Comment("Section 2.3Preprocessing");
            Log.Comment("Verify that class name namespace isn't searched");
            if (Lexical_TestClass_pre_004.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_pre_005_Test()
        {
            Log.Comment("Section 2.3Preprocessing");
            Log.Comment("Verify that invalid syntax doesn't mess up compiler in non-ifdef sections");
            if (Lexical_TestClass_pre_005.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_pre_006_Test()
        {
            Log.Comment("Section 2.3Preprocessing");
            Log.Comment("Verify #warn works");
            Log.Comment("This test has been removed because #warn is handled by VS not the MF");
            return MFTestResults.Skip;
        }
        [TestMethod]
        public MFTestResults Lexical_pre_008_Test()
        {
            Log.Comment("Section 2.3Preprocessing");
            Log.Comment("Verify #elif and #else");
            if (Lexical_TestClass_pre_008.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_preproc_09_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("#warning verification");
            if (Lexical_TestClass_preproc_09.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_preproc_30_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Verifying comments and #preprocessor items");
            Log.Comment("This define should not be included	#define TEST ");
            if (Lexical_TestClass_preproc_30.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_preproc_38_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Verify the code that is skipped because of an #if is not checked by compiler at all");
            if (Lexical_TestClass_preproc_38.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_line_02_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("#line: Valid integer-literal passed to #line should work correctly with a real warning");
            if (Lexical_TestClass_line_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_line_03_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("#line: Valid integer-literal passed to #line should work correctly with a #warning directive");
            if (Lexical_TestClass_line_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_line_06_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("#line: Valid integer-literal/string-literal passed to #line should work correctly with a real warning");
            if (Lexical_TestClass_line_06.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_line_07_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("#line: Valid integer-literal/string-literal passed to #line should work correctly with a #warning directive");
            if (Lexical_TestClass_line_07.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_line_26_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("#line: Should work cleanly inside an #if-#endif block that evaluates to false");
            if (Lexical_TestClass_line_26.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_line_35_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("#line: #line default in a false #if block should compile cleanly");
            if (Lexical_TestClass_line_35.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_01_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Make sure #region works without banner text");
            if (Lexical_TestClass_region_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_02_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Make sure #region works with banner text");
            if (Lexical_TestClass_region_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_05_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Nesting a #region inside another should work ");
            if (Lexical_TestClass_region_05.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_06_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Nesting five #region blocks should compile successfully ");
            if (Lexical_TestClass_region_06.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_07_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Nesting two #region blocks within a single #region block should compile successfully ");
            if (Lexical_TestClass_region_07.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_10_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Make sure #region works with banner text enclosed in double-quotes");
            if (Lexical_TestClass_region_10.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_11_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("A single-line comment following a #region should compile successfully");
            if (Lexical_TestClass_region_11.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_12_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("A single-line comment following an #endregion should compile successfully");
            if (Lexical_TestClass_region_12.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_region_15_Test()
        {
            Log.Comment("Section 2.3 Preprocessing");
            Log.Comment("Any text following the #endregion directive should be ignored");
            if (Lexical_TestClass_region_15.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_lineterm_01_Test()
        {
            Log.Comment("Section 2.4 Lexical Analysis");
            Log.Comment("Test different ways to end a line with semi-colon");
            if (Lexical_TestClass_lineterm_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_atkeyword_03_Test()
        {
            Log.Comment("Section 2.4 Lexical Analysis - Keywords");
            Log.Comment("The identifiers @test and test should refer to the same variable");
            if (Lexical_TestClass_atkeyword_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_atkeyword_04_Test()
        {
            Log.Comment("Section 2.4 Lexical Analysis - Keywords");
            Log.Comment("Verify that 'if' can be an identifier using unicode escape sequences as well as an @keyword");
            if (Lexical_TestClass_atkeyword_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_atkeyword_05_Test()
        {
            Log.Comment("Section 2.4 Lexical Analysis - Keywords");
            Log.Comment("Verify that prefixing an identifer that is prefixed by a double underscore does not generate warning");
            if (Lexical_TestClass_atkeyword_05.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_ident_01_Test()
        {
            Log.Comment("Section 2.4.7 Identifiers");
            Log.Comment("identifier-start-character can be alphabetic");
            if (Lexical_TestClass_ident_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_ident_02_Test()
        {
            Log.Comment("Section 2.4.7 Identifiers");
            Log.Comment("identifier-start-character can be an underscore");
            if (Lexical_TestClass_ident_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_ident_03_Test()
        {
            Log.Comment("Section 2.4.7 Identifiers");
            Log.Comment("identifier-part-character can be a number");
            if (Lexical_TestClass_ident_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_ident_04_Test()
        {
            Log.Comment("Section 2.4.7 Identifiers");
            Log.Comment("identifier-part-character can be a number (in the middle)");
            if (Lexical_TestClass_ident_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_ident_05_Test()
        {
            Log.Comment("Section 2.4.2 Identifiers");
            Log.Comment("Identifiers that start with double underscores (__) should not generate a warning/error though it used to");
            if (Lexical_TestClass_ident_05.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_ident_06_Test()
        {
            Log.Comment("Section 2.4.2 Identifiers");
            Log.Comment("Identifiers that have embedded double underscores (__) should generate a warning/error though it used to");
            if (Lexical_TestClass_ident_06.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_ident_07_Test()
        {
            Log.Comment("Section 2.4.2 Identifiers");
            Log.Comment("Identifiers that end with double underscores (__) should generate a warning/error though it used to");
            if (Lexical_TestClass_ident_07.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_nullunicode_01_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("A \\u0000 within comments should not stop compiler from reading to EOF");
            if (Lexical_TestClass_nullunicode_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_nullunicode_03_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("A \\u0000 in a string should be equal to \x0000 and \0");
            if (Lexical_TestClass_nullunicode_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_nullunicode_04_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("A \\u0000 is ignored if within preprocessor-excluded code");
            if (Lexical_TestClass_nullunicode_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_02_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("A simple program that is saved as utf-8 with Notepad compiles and runs correctly.");
            if (Lexical_TestClass_unicode_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_04_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Displaying a unicode character with Log.Comment(().ToString())");
            if (Lexical_TestClass_unicode_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_05_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Displaying a unicode character with Log.Comment(().ToString())");
            Log.Comment("Since the correct language is not installed on my machine, should get a 'QQQ' as output");
            if (Lexical_TestClass_unicode_05.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_06_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Identifier whose name is defined with \\uXXXX works correctly (Bug 111180)");
            if (Lexical_TestClass_unicode_06.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_07_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Identifier whose name starts with \\uXXXX works correctly");
            if (Lexical_TestClass_unicode_07.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_08_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Identifier whose name has a \\uXXXX in the middle of it works correctly");
            if (Lexical_TestClass_unicode_08.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_09_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Identifier whose name ends with a \\uXXXX works correctly ");
            if (Lexical_TestClass_unicode_09.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_10_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Unicode escape sequence to start preprocessor identifier");
            Log.Comment("Bug #33538 - Fixed");
            if (Lexical_TestClass_unicode_10.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_11_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Unicode escape sequence to start preprocessor identifier");
            Log.Comment("Bug #33538 - Fixed");
            if (Lexical_TestClass_unicode_11.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_12_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Unicode escape sequence to start preprocessor identifier");
            Log.Comment("Bug #33538 - Fixed");
            if (Lexical_TestClass_unicode_12.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_13_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Unicode escape sequence in middle of a #define (#de\\u0066ine)");
            Log.Comment("Bug #33538 - Fixed");
            if (Lexical_TestClass_unicode_13.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_unicode_17_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("The literal \\u0000 should not be interpreted as a unicode escape sequence");
            if (Lexical_TestClass_unicode_17.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_uni8digit_01_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Identifier whose name is defined with \\uXXXXXXXX works correctly");
            if (Lexical_TestClass_uni8digit_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_uni8digit_02_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Using Log.Comment with \\uXXXXXXXX works correctly");
            if (Lexical_TestClass_uni8digit_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_uni8digit_03_Test()
        {
            Log.Comment("Section 2.5 Lexical Analysis");
            Log.Comment("Verify valid boundaries of values for \\uXXXXXXXX work correctly");
            if (Lexical_TestClass_uni8digit_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_atstrings_01_Test()
        {
            Log.Comment("Back-Quoted String Test");
            Log.Comment("Newlines should be valid within @-quoted string literals");
            if (Lexical_TestClass_atstrings_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_atstrings_02_Test()
        {
            Log.Comment("Back-Quoted String Test");
            Log.Comment("Unicode escape sequences are not processed within @-quoted string literals");
            if (Lexical_TestClass_atstrings_02.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_atstrings_03_Test()
        {
            Log.Comment("Back-Quoted String Test");
            Log.Comment("Slash escape sequences are not processed within @-quoted string literals");
            if (Lexical_TestClass_atstrings_03.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_atstrings_04_Test()
        {
            Log.Comment("Back-Quoted String Test");
            Log.Comment("Passing @-quoted strings to Log.Comment(().ToString()) should work");
            if (Lexical_TestClass_atstrings_04.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_mscombo_01_Test()
        {
            Log.Comment("XML Doc Test (Just lexical tests, no output validation)");
            Log.Comment("Combination of multi and single line xml doc comments");
            if (Lexical_TestClass_mscombo_01.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }
        [TestMethod]
        public MFTestResults Lexical_mscombo_05_Test()
        {
            Log.Comment("XML Doc Test (Just lexical tests, no output validation)");
            Log.Comment("Combination of multi and single line xml doc comments");
            if (Lexical_TestClass_mscombo_05.testMethod())
            {
                return MFTestResults.Pass;
            }
            return MFTestResults.Fail;
        }


        //Compiled Test Cases 
        public class Lexical_TestClass_comments_01
        {
            /* This is a comment */
            public static void Main_old(String[] args) { }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_comments_02
        {
            // This is a comment
            public static void Main_old(String[] args) { }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_comments_03
        {
            // This is a comment //
            public static void Main_old(String[] args) { }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_comments_04
        {
            /* This is a comment 
	           This is a comment
	        */
            public static void Main_old(String[] args) { }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_comments_05
        {
            /* This is a comment 
	           This is a comment */
            public static void Main_old(String[] args) { }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_comments_06
        {
            /* This is a comment 
	        // This is a comment
	           This is a comment */
            public static void Main_old(String[] args) { }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_comments_07
        {
            /* This is a comment 
	        // This is a comment */
            public static void Main_old(String[] args) { }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_comments_10
        {
            // /* This is a comment 
            public static void Main_old(String[] args) { }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_bool_01
        {
            public static void Main_old(String[] args)
            {
                bool test1;
                bool test2;
                test1 = true;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_bool_02
        {
            public static void Main_old(String[] args)
            {
                bool test1;
                bool test2;
                test1 = false;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_int_01
        {
            public static void Main_old(String[] args)
            {
                int test1;
                int test2;
                test1 = 0;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_int_02
        {
            public static void Main_old(String[] args)
            {
                int test1;
                int test2;
                test1 = 10;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_int_03
        {
            public static void Main_old(String[] args)
            {
                int test1;
                int test2;
                test1 = -10;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_int_04
        {
            public static void Main_old(String[] args)
            {
                int test1;
                int test2;
                test1 = -0xF;
                test2 = test1;
                Log.Comment((test2).ToString());
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_int_05
        {
            public static void Main_old(String[] args)
            {
                int test1;
                int test2;
                test1 = 0xF;
                test2 = test1;
                Log.Comment((test2).ToString());
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_int_06
        {
            public static void Main_old(String[] args)
            {
                int test1;
                int test2;
                test1 = 0x0;
                test2 = test1;
                Log.Comment((test2).ToString());
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_intsuffix_01
        {
            public static void Main_old(String[] args)
            {
                long test1;
                long test2;
                test1 = 10L;
                test2 = test1;
                test1 = 10L;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_intsuffix_02
        {
            public static void Main_old(String[] args)
            {
                ulong test1;
                ulong test2;
                test1 = 10LU;
                test2 = test1;
                test1 = 10Ul;
                test2 = test1;
                test1 = 10uL;
                test2 = test1;
                test1 = 10ul;
                test2 = test1;
                test1 = 10LU;
                test2 = test1;
                test1 = 10Lu;
                test2 = test1;
                test1 = 10LU;
                test2 = test1;
                test1 = 10Lu;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_intsuffix_03
        {
            public static void Main_old(String[] args)
            {
                uint test1;
                uint test2;
                test1 = 10u;
                test2 = test1;
                test1 = 10U;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_intsuffix_04
        {
            public static int Main_old()
            {
                int result = 0;
                if (10UL is ulong) result += 0; else result += 1;
                if (10Ul is ulong) result += 0; else result += 1;
                if (10uL is ulong) result += 0; else result += 1;
                if (10ul is ulong) result += 0; else result += 1;
                if (10LU is ulong) result += 0; else result += 1;
                if (10Lu is ulong) result += 0; else result += 1;
                if (10LU is ulong) result += 0; else result += 1;
                if (10Lu is ulong) result += 0; else result += 1;

                Log.Comment((result).ToString());
                return result;
            }
            public static bool testMethod()
            {
                return (Main_old() == 0);
            }
        }
        public class Lexical_TestClass_intsuffix_06
        {
            public static int Main_old(String[] args)
            {
                int result = 0;
                if (10L is long) result += 0; else result += 1;
                if (10L is long) result += 0; else result += 1;
                return result;
            }
            public static bool testMethod()
            {
                if (Main_old(null) != 0)
                    return false;
                else
                    return true;
            }
        }
        public class Lexical_TestClass_intsuffix_07
        {
            public static void Main_old()
            {
                long test1;
                long test2;
                test1 = 10L;
                test2 = test1;
                test1 = 10L;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_suff_typepick_03
        {
            public static int Main_old(String[] args)
            {
                int result = 0;
                // these should all be considered of type long (lowercase suffix)
                if (-9223372036854775808L is long) result += 0; else result += 1;
                if (9223372036854775807L is long) result += 0; else result += 1;
                // these should all be considered of type long (uppercase suffix)
                if (-9223372036854775808L is long) result += 0; else result += 1;
                if (9223372036854775807L is long) result += 0; else result += 1;
                // these should all be considered of type ulong (lowercase suffix)
                if (9223372036854775808L is ulong) result += 0; else result += 1;
                if (18446744073709551615L is ulong) result += 0; else result += 1;
                // these should all be considered of type ulong (uppercase suffix)
                if (9223372036854775808L is ulong) result += 0; else result += 1;
                if (18446744073709551615L is ulong) result += 0; else result += 1;
                return result;
            }
            public static bool testMethod()
            {
                if (Main_old(null) != 0)
                    return false;
                else
                    return true;
            }
        }
        public class Lexical_TestClass_real_01
        {
            public static void Main_old(String[] args)
            {
                double test1, test2;
                test1 = 9.99;
                test2 = -9.99;
                test1 = test2;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_real_02
        {
            public static void Main_old(String[] args)
            {
                double test1, test2;
                test1 = .99;
                test2 = -.99;
                test1 = test2;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_real_03
        {
            public static void Main_old(String[] args)
            {
                double test1, test2;
                test1 = 99;
                test2 = -99;
                test1 = test2;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_real_04
        {
            public static void Main_old(String[] args)
            {
                double test1, test2, test3;
                test1 = 9.99e5;
                test2 = -9.99E-5;
                test3 = -9.99E+5;
                test1 = test2;
                test2 = test3;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_real_05
        {
            public static void Main_old(String[] args)
            {
                double test1, test2, test3;
                test1 = .99e5;
                test2 = -.99E-5;
                test3 = -.99E+5;
                test1 = test2;
                test2 = test3;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_real_06
        {
            public static void Main_old(String[] args)
            {
                double test1, test2, test3;
                test1 = 99e5;
                test2 = -99E-5;
                test3 = -99E+5;
                test1 = test2;
                test2 = test3;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_char_01
        {
            public static void Main_old(String[] args)
            {
                char test, getter;

                test = 'a';
                test = 'A';
                test = '1';
                test = '0';
                test = '9';
                test = '!';
                test = '@';
                test = '#';
                test = '$';
                test = '%';
                test = '^';
                test = '&';
                test = '*';
                test = '(';
                test = ')';
                test = '-';
                test = '=';
                test = '_';
                test = '+';
                test = '`';
                test = '~';
                test = '{';
                test = '}';
                test = '[';
                test = ']';
                test = '|';
                test = '"';
                test = ':';
                test = ';';
                test = ',';
                test = '.';
                test = '/';
                test = '<';
                test = '>';
                getter = test;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_char_02
        {
            public static void Main_old(String[] args)
            {
                char test, getter;

                test = '\'';
                test = '\"';
                test = '\\';
                test = '\0';
                test = '\a';
                test = '\b';
                test = '\f';
                test = '\n';
                test = '\r';
                test = '\t';
                test = '\v';
                getter = test;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_char_03
        {
            public static void Main_old(String[] args)
            {
                char test, getter;

                test = '\x0027';
                test = '\x0022';
                test = '\x005C';
                test = '\x0000';
                test = '\x0007';
                test = '\x0008';
                test = '\x000C';
                test = '\x000A';
                test = '\x000D';
                test = '\x0009';
                test = '\x000B';

                getter = test;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_realsuffix_01
        {
            public static void Main_old(String[] args)
            {
                double test1;
                double test2;
                test1 = -9.99D;
                test2 = 9.99d;
                test1 = .99D;
                test2 = -.99d;
                test1 = 9D;
                test2 = -9d;
                test1 = 9.99E5D;
                test2 = -9.99e-5d;
                test1 = .99e+5D;
                test2 = -9E-5d;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_realsuffix_02
        {
            public static void Main_old(String[] args)
            {
                float test1;
                float test2;
                test1 = -9.99F;
                test2 = 9.99f;
                test1 = .99F;
                test2 = -.99f;
                test1 = 9F;
                test2 = -9f;
                test1 = 9.99E5F;
                test2 = -9.99e-5f;
                test1 = .99e+5F;
                test2 = -9E-5f;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_string_01
        {
            public static void Main_old(String[] args)
            {
                String test1;
                test1 = "asdfjkl;\nasdfjkl;";
                Log.Comment((test1).ToString());
                test1 = "\"testing\'";
                Log.Comment((test1).ToString());
                test1 = "escape seq at end\\";
                Log.Comment((test1).ToString());
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_string_02
        {
            public static void Main_old(String[] args)
            {
                String test1;
                test1 = "asdfjkl;\x000Aasdfjkl;";
                Log.Comment((test1).ToString());
                test1 = "\x0022testing\x0027";
                Log.Comment((test1).ToString());
                test1 = "escape seq at end\x005C";
                Log.Comment((test1).ToString());
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_string_03
        {
            public static void Main_old(String[] args)
            {
                String test1, test2;
                test1 = null;
                test2 = test1;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }


        public class Lexical_TestClass_pre_001
        {
            public static int Main_old(string[] args)
            {
                int i = 2;
#if true
                i = 0;
#endif
#if false
	i = 1;
#endif
                return (i);
            }
            public static bool testMethod()
            {
                return (Main_old(null) == 0);
            }
        }
        public class Lexical_TestClass_pre_004
        {
            public static int Main_old(string[] args)
            {
                int i = 0;
#if Lexical_TestClass_pre_004 
	i = 1;
#endif
                return (i);
            }
            public static bool testMethod()
            {
                return (Main_old(null) == 0);
            }
        }
        public class Lexical_TestClass_pre_005
        {
            public static int Main_old(string[] args)
            {
                int i = 0;
#if false
	skdjf ksdklfj mcxnvsdh 9-u23kjd f0120 skdc.zxcnv
	sdjfu239nzjnv,mciw -32poduf.zxcnv djfs9a]du
#if true
	this shouldn't even be looked at.  Except for counting up the #if/#endif pairs
#else
	This should be skipped too!
#endif
#if false
	this shouldn't even be looked at.  Except for counting up the #if/#endif pairs
#else
	This should be skipped too!
#endif
	This should also be ignored
#endif
                return (i);
            }
            public static bool testMethod()
            {
                return (Main_old(null) == 0);
            }
        }
 
/*
        public class Lexical_TestClass_pre_006
        {
            public static int Main_old(string[] args)
            {
                int i = 0;
#warning Klaatu barada nikto
#if false
#if true
#error This wasn't supposed to trigger
#else
#error This wasn't supposed to trigger either
#endif
#endif
                return (i);
            }
            public static bool testMethod()
            {
                return (Main_old(null) == 0);
            }
        }
*/
        public class Lexical_TestClass_pre_008
        {
            public static int Main_old(string[] args)
            {
                int i = 2;
#if false
#error false is true?
#elif true
                i--;
#else
#error Else shouldn't trigger here
#endif
#if false
#error false is still true?
#elif foobar
#error foobar wasn't supposed to be defined
#else
                i--;
#endif
                return (i > 0 ? 1 : 0);
            }
            public static bool testMethod()
            {
                return (Main_old(null) == 0);
            }
        }
        class Lexical_TestClass_preproc_09
        {
            public static void Main_old(String[] args)
            {
#warning This is a WARNING!
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }




        class Lexical_TestClass_preproc_30
        {
            public static void Main_old(String[] args)
            {
#if TEST
			Log.Comment("Bad");
#else
                Log.Comment("Good");
#endif
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        class Lexical_TestClass_preproc_38
        {
            public static void Main_old(String[] args)
            {
#if foo
			this code should be completely skipped
#else
                Log.Comment("Else triggered");
#endif
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_line_02
        {
            public static void Main_old()
            {
#line 13
                int a = 3;
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_line_03
        {
            public static void Main_old()
            {
#line 13
#warning This is a warning
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_line_06
        {
            public static void Main_old()
            {
#line 13 "myfile.cs"
                int a = 3;
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }


        public class Lexical_TestClass_line_07
        {
            public static void Main_old()
            {
#line 13 "myfile.cs"
#warning This is a warning
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_line_26
        {
            public static void Main_old()
            {
#if false
#line 13
        short s = 123456;       
#endif
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_line_35
        {
            public static void Main_old()
            {
#if false
#line default
        short s1 = 123456;   
#endif
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }



        public class Lexical_TestClass_region_01
        {
            public static void Main_old()
            {
                #region
                Log.Comment("This works!");
                #endregion
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_region_02
        {
            public static void Main_old()
            {
                #region This is the banner text
                Log.Comment("This works!");
                #endregion
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_region_05
        {
            public static void Main_old()
            {
                #region
                Log.Comment("1");
                #region
                Log.Comment("2");
                #endregion
                Log.Comment("3");
                #endregion
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_region_06
        {
            public static void Main_old()
            {
                #region
                Log.Comment("1");
                #region
                Log.Comment("2");
                #region
                Log.Comment("3");
                #region
                Log.Comment("4");
                #region
                Log.Comment("5");
                #endregion
                Log.Comment("6");
                #endregion
                Log.Comment("7");
                #endregion
                Log.Comment("8");
                #endregion
                Log.Comment("9");
                #endregion
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_region_07
        {
            public static void Main_old()
            {
                #region
                Log.Comment("1");
                #region
                Log.Comment("2");
                #endregion
                Log.Comment("3");
                #region
                Log.Comment("4");
                #endregion
                Log.Comment("5");
                #endregion
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_region_10
        {
            public static void Main_old()
            {
                #region "This is the banner text"
                Log.Comment("This works!");
                #endregion
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_region_11
        {
            public static void Main_old()
            {
                #region // This is a single-line comment
                Log.Comment("This works!");
                #endregion
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_region_12
        {
            public static void Main_old()
            {
                #region
                Log.Comment("This works!");
                #endregion // This is a single-line comment
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }




        public class Lexical_TestClass_region_15
        {
            public static void Main_old()
            {
                #region
                Log.Comment("This works!");
                #endregion This text should be ignored
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_lineterm_01
        {
            public static void Main_old(String[] args)
            {
                Log.Comment("1");			// normal
                Log.Comment("2");		// space between
                Log.Comment("3")
                ;								// ; on the next line
                Log.Comment("4")
                    // comment in between
                                      ;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_atkeyword_03
        {
            public static void Main_old(String[] args)
            {
                int @test;
                test = 5;
                Log.Comment((@test).ToString());
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        class Lexical_TestClass_atkeyword_04
        {
            static int Main_old()
            {
                string \u0069f;
                @if = "Hello, world";
                Log.Comment((i\u0066).ToString());

                if (@if == "Hello, world")
                    return 0;
                else
                    return 1;
            }
            public static bool testMethod()
            {
                return (Main_old() == 0);
            }
        }
        class Lexical_TestClass_atkeyword_05
        {
            static void Main_old()
            {
                int @__test;
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        public class Lexical_TestClass_ident_01
        {
            public static void Main_old(String[] args)
            {
                int alpha = 4;
                int Alpha = 5;
                Alpha = alpha;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        public class Lexical_TestClass_ident_02
        {
            public static void Main_old(String[] args)
            {
                int _alpha = 4;
                int _Alpha = 5;
                _Alpha = _alpha;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }





        public class Lexical_TestClass_ident_03
        {
            public static void Main_old(String[] args)
            {
                int alpha4 = 4;
                int Alpha3 = 5;
                Alpha3 = alpha4;
            }
            public static bool testMethod()
            {
                Main_old(null);
                return true;
            }
        }
        class Lexical_TestClass_ident_04
        {
            static void Main_old()
            {
                int alpha4a = 4;
                int Alpha3a = 5;
                Alpha3a = alpha4a;
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_ident_05
        {
            static void Main_old()
            {
                int __alpha4 = 4;
                int __Alpha3 = 5;
                __Alpha3 = __alpha4;
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_ident_06
        {
            static void Main_old()
            {
                int x__alpha4 = 4;
                int x__Alpha3 = 5;
                x__Alpha3 = x__alpha4;
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_ident_07
        {
            static void Main_old()
            {
                int alpha4__ = 4;
                int Alpha3__ = 5;
                Alpha3__ = alpha4__;
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_nullunicode_01
        {
            public static void Main_old()
            {
                // This should not stop the compiler from moving on \u0000

                Log.Comment("Worked");
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_nullunicode_03
        {
            public static int Main_old()
            {
                string first = "This string\0 should show";
                string second = "This string\u0000 should show";
                string third = "This string\x0000 should show";
                if ((first == second) && (second == third))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            public static bool testMethod()
            {
                return (Main_old() == 0);
            }
        }
        class Lexical_TestClass_nullunicode_04
        {
            public static int Main_old()
            {
#if NOTDEFINED

			\u0000  // This should be ignored	

#endif
                return 0;
            }
            public static bool testMethod()
            {
                return (Main_old() == 0);
            }
        }
﻿// <StdHeader/>
        class Lexical_TestClass_unicode_02
        {
            public static void Main_old()
            {
                Log.Comment("Worked!");
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }




        class Lexical_TestClass_unicode_04
        {
            public static void Main_old()
            {
                Log.Comment("\u0057");
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_unicode_05
        {
            public static void Main_old()
            {
                Log.Comment("\u0701");
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_unicode_06
        {
            public static void Main_old()
            {
                int \u0057ash;
                Wash = 3;
                Log.Comment((Wash).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_unicode_07
        {
            public static void Main_old()
            {
                int \u0391Lpha;  // \u0391 is the capital greek letter Alpha
                \u0391Lpha = 3;
                Log.Comment((\u0391Lpha).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_unicode_08
        {
            public static void Main_old()
            {
                int start\u0391Lpha;  // \u0391 is the capital greek letter Alpha
                start\u0391Lpha = 3;
                Log.Comment((start\u0391Lpha).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }


        class Lexical_TestClass_unicode_09
        {
            public static void Main_old()
            {
                int lpha\u0391;  // \u0391 is the capital greek letter Alpha
                lpha\u0391 = 3;
                Log.Comment((lpha\u0391).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }


        class Lexical_TestClass_unicode_17
        {
            public static void Main_old()
            {
                string s = "\\u0000";
                Log.Comment((s).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }


        class Lexical_TestClass_uni8digit_01
        {
            public static void Main_old()
            {
                int \U00000057ash;
                Wash = 3;
                Log.Comment((Wash).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_uni8digit_02
        {
            static void Main_old()
            {
                Log.Comment("\U00000057ash");
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_uni8digit_03
        {
            static void Main_old()
            {
                string a = "\U00000000";
                string b = "\U0010FFFF";
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_atstrings_01
        {
            public const string hello = @"hel
lo";
            public static void Main_old()
            {
                Log.Comment((hello).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_atstrings_02
        {
            public static string a = @"hello, world!";
            public static string b = @"\u0068ello, world!";
            public static void Main_old()
            {
                Log.Comment((a).ToString());
                Log.Comment((b).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_atstrings_03
        {
            public static string a = @"Hello,\nworld";
            public static string b = @"Hello,\tworld";
            public static void Main_old()
            {
                Log.Comment((a).ToString());
                Log.Comment((b).ToString());
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_atstrings_04
        {
            public static void Main_old()
            {
                Log.Comment(@"Hello, world!");
                Log.Comment(@"Testing");
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_mscombo_01
        {

            /// This is the summary

            public int Field = 0;
            static void Main_old() { }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_mscombo_05
        {

            /// This is the summary 

            public int Field = 0;
            static void Main_old() { }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }


        class Lexical_TestClass_unicode_10
        {
            public static void Main_old()
            {
#if foobar2
                Log.Comment("Worked!");
#endif
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_unicode_11
        {
            public static void Main_old()
            {
#if middlefoobar
                Log.Comment("Worked!");
#endif
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_unicode_12
        {
            public static void Main_old()
            {
#if endf
                Log.Comment("Worked!");
#endif
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }
        class Lexical_TestClass_unicode_13
        {
            public static void Main_old()
            {
#if endf2
                Log.Comment("Worked!");
#endif
            }
            public static bool testMethod()
            {
                Main_old();
                return true;
            }
        }

    }
}
