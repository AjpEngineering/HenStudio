#region HEADER
//#####################################################################################################################
//#############################  F o r m U s e r L i c e n s e A g r e e m e n t . c s  ###############################
//#####################################################################################################################
//  FILENAME:  FormUserLicenseAgreement.cs
//  NAMESPACE: HenStudio
//  CLASS(S):  FormUserLicenseAgreement
//  COMPONENT: HenStudio.exe
//=====================================================================================================================
//  DESCRIPTION: 
//    This file contains the code for the User License Agreement Form class.
//=====================================================================================================================
//  AUTHOR:
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//                                                                                                                   !!
//                              A        JJJJJJJJ  PPPPPPP         EEEEEEE  NN     NN   GGGGGG                       !!
//                             AAA          JJ     PP    PP        EE       NNN    NN  GG    GG                      !!
//                            AA AA         JJ     PP    PP        EE       NNNN   NN  GG                            !!
//                           AA   AA        JJ     PPPPPP          EEEEEEE  NN NN  NN  GG   GGGG                     !!
//                          AAAAAAAA   JJ   JJ     PP              EE       NN  NN NN  GG    GG                      !!
//                         AA      AA  JJ   JJ     PP              EE       NN    NNN  GG    GG                      !!
//                        AA        AA  JJJJJJ     PP              EEEEEEE  NN     NN   GGGGGG                       !!
//                                                                                                                   !!
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//    (c)Copyright 2026 AJP Engineering
//    All rights reserved.
//=====================================================================================================================
//  HISTORY:
//    01/01/26 .. pg .. Version 4.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion  // REFERENCES

#region namespace HenStudio
namespace HenStudio
{
    #region partial class FormUserLicenseAgreement : Form
    public partial class FormUserLicenseAgreement : Form
    {
        #region CTOR
        /// <summary>
        /// Default CTOR
        /// </summary>
        public FormUserLicenseAgreement()
        {
            InitializeComponent();
        }
        #endregion  //// CTOR

        #region FormUserLicenseAgreement_Load
        /// <summary>
        /// Assign RTF text to the Rich Text Box control on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUserLicenseAgreement_Load(object sender, EventArgs e)
        {
            #region ASSIGN RTF TO RICH TEXT BOX
            richTextBoxAgreement.Rtf = @"{\rtf1\adeflang1025\ansi\ansicpg1252\uc1\adeff31507\deff0\stshfdbch31506\stshfloch31506\stshfhich31506\stshfbi31507\deflang1033\deflangfe1033\themelang1033\themelangfe0\themelangcs0{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f2\fbidi \fmodern\fcharset0\fprq1{\*\panose 02070309020205020404}Courier New;}
{\f3\fbidi \froman\fcharset2\fprq2{\*\panose 05050102010706020507}Symbol;}{\f10\fbidi \fnil\fcharset2\fprq2{\*\panose 05000000000000000000}Wingdings;}{\f34\fbidi \froman\fcharset0\fprq2{\*\panose 02040503050406030204}Cambria Math;}
{\f44\fbidi \fmodern\fcharset0\fprq2{\*\panose 00000000000000000000}Karmina;}{\flomajor\f31500\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
{\fdbmajor\f31501\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhimajor\f31502\fbidi \fmodern\fcharset0\fprq2{\*\panose 00000000000000000000}Karmina;}
{\fbimajor\f31503\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\flominor\f31504\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}
{\fdbminor\f31505\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\fhiminor\f31506\fbidi \fmodern\fcharset0\fprq2{\*\panose 00000000000000000000}Karmina;}
{\fbiminor\f31507\fbidi \froman\fcharset0\fprq2{\*\panose 02020603050405020304}Times New Roman;}{\f47\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\f48\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\f50\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\f51\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\f52\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\f53\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\f54\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\f55\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\f57\fbidi \fmodern\fcharset238\fprq1 Courier New CE;}{\f58\fbidi \fmodern\fcharset204\fprq1 Courier New Cyr;}
{\f60\fbidi \fmodern\fcharset161\fprq1 Courier New Greek;}{\f61\fbidi \fmodern\fcharset162\fprq1 Courier New Tur;}{\f62\fbidi \fmodern\fcharset177\fprq1 Courier New (Hebrew);}{\f63\fbidi \fmodern\fcharset178\fprq1 Courier New (Arabic);}
{\f64\fbidi \fmodern\fcharset186\fprq1 Courier New Baltic;}{\f65\fbidi \fmodern\fcharset163\fprq1 Courier New (Vietnamese);}{\f67\fbidi \froman\fcharset238\fprq2 Cambria Math CE;}{\f68\fbidi \froman\fcharset204\fprq2 Cambria Math Cyr;}
{\f70\fbidi \froman\fcharset161\fprq2 Cambria Math Greek;}{\f71\fbidi \froman\fcharset162\fprq2 Cambria Math Tur;}{\f74\fbidi \froman\fcharset186\fprq2 Cambria Math Baltic;}{\f75\fbidi \froman\fcharset163\fprq2 Cambria Math (Vietnamese);}
{\f77\fbidi \fmodern\fcharset238\fprq2 Karmina CE;}{\f80\fbidi \fmodern\fcharset161\fprq2 Karmina Greek;}{\f81\fbidi \fmodern\fcharset162\fprq2 Karmina Tur;}{\f84\fbidi \fmodern\fcharset186\fprq2 Karmina Baltic;}
{\flomajor\f31508\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\flomajor\f31509\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\flomajor\f31511\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\flomajor\f31512\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\flomajor\f31513\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\flomajor\f31514\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\flomajor\f31515\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\flomajor\f31516\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fdbmajor\f31518\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
{\fdbmajor\f31519\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fdbmajor\f31521\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fdbmajor\f31522\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
{\fdbmajor\f31523\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fdbmajor\f31524\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fdbmajor\f31525\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
{\fdbmajor\f31526\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fhimajor\f31528\fbidi \fmodern\fcharset238\fprq2 Karmina CE;}{\fhimajor\f31531\fbidi \fmodern\fcharset161\fprq2 Karmina Greek;}
{\fhimajor\f31532\fbidi \fmodern\fcharset162\fprq2 Karmina Tur;}{\fhimajor\f31535\fbidi \fmodern\fcharset186\fprq2 Karmina Baltic;}{\fbimajor\f31538\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
{\fbimajor\f31539\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fbimajor\f31541\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fbimajor\f31542\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
{\fbimajor\f31543\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fbimajor\f31544\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fbimajor\f31545\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
{\fbimajor\f31546\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\flominor\f31548\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\flominor\f31549\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\flominor\f31551\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flominor\f31552\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\flominor\f31553\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
{\flominor\f31554\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flominor\f31555\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\flominor\f31556\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
{\fdbminor\f31558\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbminor\f31559\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fdbminor\f31561\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\fdbminor\f31562\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbminor\f31563\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fdbminor\f31564\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\fdbminor\f31565\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbminor\f31566\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fhiminor\f31568\fbidi \fmodern\fcharset238\fprq2 Karmina CE;}
{\fhiminor\f31571\fbidi \fmodern\fcharset161\fprq2 Karmina Greek;}{\fhiminor\f31572\fbidi \fmodern\fcharset162\fprq2 Karmina Tur;}{\fhiminor\f31575\fbidi \fmodern\fcharset186\fprq2 Karmina Baltic;}
{\fbiminor\f31578\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fbiminor\f31579\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fbiminor\f31581\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\fbiminor\f31582\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fbiminor\f31583\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fbiminor\f31584\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\fbiminor\f31585\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fbiminor\f31586\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}}{\colortbl;\red0\green0\blue0;\red0\green0\blue255;\red0\green255\blue255;\red0\green255\blue0;
\red255\green0\blue255;\red255\green0\blue0;\red255\green255\blue0;\red255\green255\blue255;\red0\green0\blue128;\red0\green128\blue128;\red0\green128\blue0;\red128\green0\blue128;\red128\green0\blue0;\red128\green128\blue0;\red128\green128\blue128;
\red192\green192\blue192;\red0\green0\blue0;\red0\green0\blue0;\caccentone\ctint255\cshade191\red15\green71\blue97;\ctextone\ctint166\cshade255\red89\green89\blue89;\ctextone\ctint216\cshade255\red39\green39\blue39;
\ctextone\ctint191\cshade255\red64\green64\blue64;}{\*\defchp \f31506\fs24\kerning2 }{\*\defpap \ql \li0\ri0\sa160\sl278\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 }\noqfpromote {\stylesheet{
\ql \li0\ri0\sa160\sl278\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31507\afs24\alang1025 \ltrch\fcs0 \f31506\fs24\lang1033\langfe1033\kerning2\cgrid\langnp1033\langfenp1033 
\snext0 \sqformat \spriority0 \styrsid13139276 Normal;}{\s1\ql \li0\ri0\sb360\sa80\sl278\slmult1\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel0\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31503\afs40\alang1025 \ltrch\fcs0 
\fs40\cf19\lang1033\langfe1033\kerning2\loch\f31502\hich\af31502\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink15 \sqformat \spriority9 \styrsid13139276 heading 1;}{\s2\ql \li0\ri0\sb160\sa80\sl278\slmult1
\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel1\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31503\afs32\alang1025 \ltrch\fcs0 
\fs32\cf19\lang1033\langfe1033\kerning2\loch\f31502\hich\af31502\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink16 \ssemihidden \sunhideused \sqformat \spriority9 \styrsid13139276 heading 2;}{\s3\ql \li0\ri0\sb160\sa80\sl278\slmult1
\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31503\afs28\alang1025 \ltrch\fcs0 
\fs28\cf19\lang1033\langfe1033\kerning2\loch\f31506\hich\af31506\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink17 \ssemihidden \sunhideused \sqformat \spriority9 \styrsid13139276 heading 3;}{\s4\ql \li0\ri0\sb80\sa40\sl278\slmult1
\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel3\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \ai\af31503\afs24\alang1025 \ltrch\fcs0 
\i\fs24\cf19\lang1033\langfe1033\kerning2\loch\f31506\hich\af31506\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink18 \ssemihidden \sunhideused \sqformat \spriority9 \styrsid13139276 heading 4;}{\s5\ql \li0\ri0\sb80\sa40\sl278\slmult1
\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel4\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31503\afs24\alang1025 \ltrch\fcs0 
\fs24\cf19\lang1033\langfe1033\kerning2\loch\f31506\hich\af31506\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink19 \ssemihidden \sunhideused \sqformat \spriority9 \styrsid13139276 heading 5;}{\s6\ql \li0\ri0\sb40\sl278\slmult1
\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel5\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \ai\af31503\afs24\alang1025 \ltrch\fcs0 
\i\fs24\cf20\lang1033\langfe1033\kerning2\loch\f31506\hich\af31506\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink20 \ssemihidden \sunhideused \sqformat \spriority9 \styrsid13139276 heading 6;}{\s7\ql \li0\ri0\sb40\sl278\slmult1
\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel6\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31503\afs24\alang1025 \ltrch\fcs0 
\fs24\cf20\lang1033\langfe1033\kerning2\loch\f31506\hich\af31506\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink21 \ssemihidden \sunhideused \sqformat \spriority9 \styrsid13139276 heading 7;}{\s8\ql \li0\ri0\sl278\slmult1
\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel7\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \ai\af31503\afs24\alang1025 \ltrch\fcs0 
\i\fs24\cf21\lang1033\langfe1033\kerning2\loch\f31506\hich\af31506\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink22 \ssemihidden \sunhideused \sqformat \spriority9 \styrsid13139276 heading 8;}{\s9\ql \li0\ri0\sl278\slmult1
\keep\keepn\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel8\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31503\afs24\alang1025 \ltrch\fcs0 
\fs24\cf21\lang1033\langfe1033\kerning2\loch\f31506\hich\af31506\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink23 \ssemihidden \sunhideused \sqformat \spriority9 \styrsid13139276 heading 9;}{\*\cs10 \additive 
\ssemihidden \sunhideused \spriority1 Default Paragraph Font;}{\*
\ts11\tsrowd\trftsWidthB3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfb3\trpaddfr3\trcbpat1\trcfpat1\tblind0\tblindtype3\tsvertalt\tsbrdrt\tsbrdrl\tsbrdrb\tsbrdrr\tsbrdrdgl\tsbrdrdgr\tsbrdrh\tsbrdrv \ql \li0\ri0\sa160\sl278\slmult1
\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31507\afs24\alang1025 \ltrch\fcs0 \f31506\fs24\lang1033\langfe1033\kerning2\cgrid\langnp1033\langfenp1033 \snext11 \ssemihidden \sunhideused Normal Table;}{\*\cs15 
\additive \rtlch\fcs1 \af31503\afs40 \ltrch\fcs0 \fs40\cf19\loch\f31502\hich\af31502\dbch\af31501 \sbasedon10 \slink1 \spriority9 \styrsid13139276 Heading 1 Char;}{\*\cs16 \additive \rtlch\fcs1 \af31503\afs32 \ltrch\fcs0 
\fs32\cf19\loch\f31502\hich\af31502\dbch\af31501 \sbasedon10 \slink2 \ssemihidden \spriority9 \styrsid13139276 Heading 2 Char;}{\*\cs17 \additive \rtlch\fcs1 \af31503\afs28 \ltrch\fcs0 \fs28\cf19\dbch\af31501 
\sbasedon10 \slink3 \ssemihidden \spriority9 \styrsid13139276 Heading 3 Char;}{\*\cs18 \additive \rtlch\fcs1 \ai\af31503 \ltrch\fcs0 \i\cf19\dbch\af31501 \sbasedon10 \slink4 \ssemihidden \spriority9 \styrsid13139276 Heading 4 Char;}{\*\cs19 \additive 
\rtlch\fcs1 \af31503 \ltrch\fcs0 \cf19\dbch\af31501 \sbasedon10 \slink5 \ssemihidden \spriority9 \styrsid13139276 Heading 5 Char;}{\*\cs20 \additive \rtlch\fcs1 \ai\af31503 \ltrch\fcs0 \i\cf20\dbch\af31501 
\sbasedon10 \slink6 \ssemihidden \spriority9 \styrsid13139276 Heading 6 Char;}{\*\cs21 \additive \rtlch\fcs1 \af31503 \ltrch\fcs0 \cf20\dbch\af31501 \sbasedon10 \slink7 \ssemihidden \spriority9 \styrsid13139276 Heading 7 Char;}{\*\cs22 \additive 
\rtlch\fcs1 \ai\af31503 \ltrch\fcs0 \i\cf21\dbch\af31501 \sbasedon10 \slink8 \ssemihidden \spriority9 \styrsid13139276 Heading 8 Char;}{\*\cs23 \additive \rtlch\fcs1 \af31503 \ltrch\fcs0 \cf21\dbch\af31501 
\sbasedon10 \slink9 \ssemihidden \spriority9 \styrsid13139276 Heading 9 Char;}{\s24\ql \li0\ri0\sa80\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\contextualspace \rtlch\fcs1 \af31503\afs56\alang1025 \ltrch\fcs0 
\fs56\expnd-2\expndtw-10\lang1033\langfe1033\kerning28\loch\f31502\hich\af31502\dbch\af31501\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink25 \sqformat \spriority10 \styrsid13139276 Title;}{\*\cs25 \additive \rtlch\fcs1 \af31503\afs56 
\ltrch\fcs0 \fs56\expnd-2\expndtw-10\kerning28\loch\f31502\hich\af31502\dbch\af31501 \sbasedon10 \slink24 \spriority10 \styrsid13139276 Title Char;}{\s26\ql \li0\ri0\sa160\sl278\slmult1
\widctlpar\wrapdefault\aspalpha\aspnum\faauto\ilvl1\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31503\afs28\alang1025 \ltrch\fcs0 \fs28\expnd3\expndtw15\cf20\lang1033\langfe1033\kerning2\loch\f31506\hich\af31506\dbch\af31501\cgrid\langnp1033\langfenp1033 
\sbasedon0 \snext0 \slink27 \sqformat \spriority11 \styrsid13139276 Subtitle;}{\*\cs27 \additive \rtlch\fcs1 \af31503\afs28 \ltrch\fcs0 \fs28\expnd3\expndtw15\cf20\dbch\af31501 \sbasedon10 \slink26 \spriority11 \styrsid13139276 Subtitle Char;}{
\s28\ql \li720\ri0\sa160\sl278\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin720\itap0\contextualspace \rtlch\fcs1 \af31507\afs24\alang1025 \ltrch\fcs0 \f31506\fs24\lang1033\langfe1033\kerning2\cgrid\langnp1033\langfenp1033 
\sbasedon0 \snext28 \sqformat \spriority34 \styrsid13139276 List Paragraph;}{\s29\qc \li0\ri0\sb160\sa160\sl278\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \ai\af31507\afs24\alang1025 \ltrch\fcs0 
\i\f31506\fs24\cf22\lang1033\langfe1033\kerning2\cgrid\langnp1033\langfenp1033 \sbasedon0 \snext0 \slink30 \sqformat \spriority29 \styrsid13139276 Quote;}{\*\cs30 \additive \rtlch\fcs1 \ai\af0 \ltrch\fcs0 \i\cf22 
\sbasedon10 \slink29 \spriority29 \styrsid13139276 Quote Char;}{\s31\qc \li864\ri864\sb360\sa360\sl278\slmult1\widctlpar\brdrt\brdrs\brdrw10\brsp200\brdrcf19 \brdrb\brdrs\brdrw10\brsp200\brdrcf19 
\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin864\lin864\itap0 \rtlch\fcs1 \ai\af31507\afs24\alang1025 \ltrch\fcs0 \i\f31506\fs24\cf19\lang1033\langfe1033\kerning2\cgrid\langnp1033\langfenp1033 
\sbasedon0 \snext0 \slink32 \sqformat \spriority30 \styrsid13139276 Intense Quote;}{\*\cs32 \additive \rtlch\fcs1 \ai\af0 \ltrch\fcs0 \i\cf19 \sbasedon10 \slink31 \spriority30 \styrsid13139276 Intense Quote Char;}{\*\cs33 \additive \rtlch\fcs1 \ai\af0 
\ltrch\fcs0 \i\cf19 \sbasedon10 \sqformat \spriority21 \styrsid13139276 Intense Emphasis;}{\*\cs34 \additive \rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\scaps\expnd1\expndtw5\cf19 \sbasedon10 \sqformat \spriority32 \styrsid13139276 Intense Reference;}}
{\*\listtable{\list\listtemplateid-1468345878{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\levelspace0\levelindent0{\leveltext\'01\u-3913 ?;}{\levelnumbers;}\f3\fs20\fbias0 \fi-360\li720\jclisttab\tx720\lin720 }
{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01o;}{\levelnumbers;}\f2\fs20\fbias0 \fi-360\li1440\jclisttab\tx1440\lin1440 }{\listlevel\levelnfc23\levelnfcn23\leveljc0
\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li2160\jclisttab\tx2160\lin2160 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1
\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li2880\jclisttab\tx2880\lin2880 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0
\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li3600\jclisttab\tx3600\lin3600 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext
\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li4320\jclisttab\tx4320\lin4320 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}
\f10\fs20\fbias0 \fi-360\li5040\jclisttab\tx5040\lin5040 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li5760
\jclisttab\tx5760\lin5760 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li6480\jclisttab\tx6480\lin6480 }
{\listname ;}\listid428358963}{\list\listtemplateid1471576940{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\levelspace0\levelindent0{\leveltext\'01\u-3913 ?;}{\levelnumbers;}\f3\fs20\fbias0 \fi-360\li720
\jclisttab\tx720\lin720 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01o;}{\levelnumbers;}\f2\fs20\fbias0 \fi-360\li1440\jclisttab\tx1440\lin1440 }{\listlevel
\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li2160\jclisttab\tx2160\lin2160 }{\listlevel\levelnfc23\levelnfcn23\leveljc0
\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li2880\jclisttab\tx2880\lin2880 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1
\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li3600\jclisttab\tx3600\lin3600 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0
\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li4320\jclisttab\tx4320\lin4320 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext
\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li5040\jclisttab\tx5040\lin5040 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}
\f10\fs20\fbias0 \fi-360\li5760\jclisttab\tx5760\lin5760 }{\listlevel\levelnfc23\levelnfcn23\leveljc0\leveljcn0\levelfollow0\levelstartat1\lvltentative\levelspace0\levelindent0{\leveltext\'01\u-3929 ?;}{\levelnumbers;}\f10\fs20\fbias0 \fi-360\li6480
\jclisttab\tx6480\lin6480 }{\listname ;}\listid1472944895}}{\*\listoverridetable{\listoverride\listid428358963\listoverridecount0\ls1}{\listoverride\listid1472944895\listoverridecount0\ls2}}{\*\rsidtbl \rsid1590941\rsid1837160\rsid2315357\rsid2908686
\rsid4276433\rsid8142815\rsid10956650\rsid13139276}{\mmathPr\mmathFont34\mbrkBin0\mbrkBinSub0\msmallFrac0\mdispDef1\mlMargin0\mrMargin0\mdefJc1\mwrapIndent1440\mintLim0\mnaryLim1}{\info{\author Philip Giorgio}{\operator Philip Giorgio}
{\creatim\yr2026\mo5\dy27\hr14\min41}{\revtim\yr2026\mo5\dy27\hr14\min41}{\version2}{\edmins1}{\nofpages3}{\nofwords881}{\nofchars5028}{\nofcharsws5898}{\vern15}}{\*\xmlnstbl {\xmlns1 http://schemas.microsoft.com/office/word/2003/wordml}}
\paperw12240\paperh15840\margl1440\margr1440\margt1440\margb1440\gutter0\ltrsect 
\widowctrl\ftnbj\aenddoc\trackmoves0\trackformatting1\donotembedsysfont1\relyonvml0\donotembedlingdata0\grfdocevents0\validatexml1\showplaceholdtext0\ignoremixedcontent0\saveinvalidxml0\showxmlerrors1\noxlattoyen
\expshrtn\noultrlspc\dntblnsbdb\nospaceforul\formshade\horzdoc\dgmargin\dghspace180\dgvspace180\dghorigin1440\dgvorigin1440\dghshow1\dgvshow1
\jexpand\viewkind1\viewscale150\pgbrdrhead\pgbrdrfoot\splytwnine\ftnlytwnine\htmautsp\nolnhtadjtbl\useltbaln\alntblind\lytcalctblwd\lyttblrtgr\lnbrkrule\nobrkwrptbl\snaptogridincell\allowfieldendsel\wrppunct
\asianbrkrule\rsidroot4276433\newtblstyruls\nogrowautofit\usenormstyforlist\noindnmbrts\felnbrelev\nocxsptable\indrlsweleven\noafcnsttbl\afelev\utinl\hwelev\spltpgpar\notcvasp\notbrkcnstfrctbl\notvatxbx\krnprsnet\cachedcolbal \nouicompat \fet0
{\*\wgrffmtfilter 2450}\nofeaturethrottle1\ilfomacatclnup0\ltrpar \sectd \ltrsect\linex0\endnhere\sectlinegrid360\sectdefaultcl\sftnbj {\*\pnseclvl1\pnucrm\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl2\pnucltr\pnstart1\pnindent720\pnhang 
{\pntxta .}}{\*\pnseclvl3\pndec\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl4\pnlcltr\pnstart1\pnindent720\pnhang {\pntxta )}}{\*\pnseclvl5\pndec\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl6\pnlcltr\pnstart1\pnindent720\pnhang 
{\pntxtb (}{\pntxta )}}{\*\pnseclvl7\pnlcrm\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl8\pnlcltr\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl9\pnlcrm\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}
\pard\plain \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel1\adjustright\rin0\lin0\itap0\pararsid4276433 \rtlch\fcs1 \af31507\afs24\alang1025 \ltrch\fcs0 
\f31506\fs24\lang1033\langfe1033\kerning2\cgrid\langnp1033\langfenp1033 {\rtlch\fcs1 \ab\af0\afs36 \ltrch\fcs0 \b\f0\fs36\kerning0\insrsid4276433\charrsid4276433 End User License Agreement (EULA)
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 Last Updated:}{\rtlch\fcs1 \af0 
\ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433  May 27, 2026
\par }{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 
IMPORTANT: PLEASE READ THIS END USER LICENSE AGREEMENT (""AGREEMENT"") CAREFULLY BEFORE DOWNLOADING, INSTALLING, OR USING THE SOFTWARE ACCOMPANYING THIS AGREEMENT. BY DOWNLOADING, INSTALLING, OR USING THE SOFTWARE, YOU ARE AGREEING TO BE BOUND BY THE TERMS 
OF THIS AGREEMENT. IF YOU DO NOT AGREE TO THE TERMS OF THIS AGREEMENT, DO NOT DOWNLOAD, INSTALL, OR USE THE SOFTWARE.}{\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
\par This Agreement is a legal contract between }{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 AJP Engineering}{\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
 (""Company,"" ""we,"" ""us,"" or ""our"") and you, either an individual or a single legal entity (""End User,"" ""you,"" or ""your""), governing your use of the software application, including any updates, upgrades, and documentation provided by us (collectively, the 
""Software"").
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
1. License Grant
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
Subject to your strict compliance with the terms of this Agreement, AJP Engineering grants you a revocable, non-exclusive, non-transferable, non-sublicensable, limited license to download, install, and use the Software solely for your personal or internal
 business operations, in accordance with the user documentation provided by the Company.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
2. Restrictions on Use
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
You agree that you will not, and will not permit any third party to:
\par {\listtext\pard\plain\ltrpar \rtlch\fcs1 \ab\af0 \ltrch\fcs0 \f3\fs20\insrsid4276433\charrsid4276433 \loch\af3\dbch\af0\hich\f3 \'b7\tab}}\pard \ltrpar\ql \fi-360\li720\ri0\sb100\sa100\sbauto1\saauto1\widctlpar
\jclisttab\tx720\wrapdefault\aspalpha\aspnum\faauto\ls1\adjustright\rin0\lin720\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 Modify or Reverse Engineer:}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\f0\kerning0\insrsid4276433\charrsid4276433  Decompile, reverse engineer, disassemble, attempt to derive the source code of, or decrypt the Software.
\par {\listtext\pard\plain\ltrpar \rtlch\fcs1 \ab\af0 \ltrch\fcs0 \f3\fs20\insrsid4276433\charrsid4276433 \loch\af3\dbch\af0\hich\f3 \'b7\tab}}{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 Distribute or Commercialize:}{
\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433  Rent, lease, lend, sell, redistribute, sublicense, or publicly display the Software.
\par {\listtext\pard\plain\ltrpar \rtlch\fcs1 \ab\af0 \ltrch\fcs0 \f3\fs20\insrsid4276433\charrsid4276433 \loch\af3\dbch\af0\hich\f3 \'b7\tab}}{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 Circumvent Security:}{\rtlch\fcs1 
\af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433  Modify or remove any proprietary notices, labels, or security features within the Software.
\par {\listtext\pard\plain\ltrpar \rtlch\fcs1 \ab\af0 \ltrch\fcs0 \f3\fs20\insrsid4276433\charrsid4276433 \loch\af3\dbch\af0\hich\f3 \'b7\tab}}{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 Unlawful Use:}{\rtlch\fcs1 \af0 
\ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433  Use the Software for any unlawful purpose or in violation of any applicable local, national, or international laws or regulations.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
3. Intellectual Property Rights
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
You acknowledge and agree that the Software and all copyrights, patents, trademarks, trade secrets, and other intellectual property rights associated therewith are, and shall remain, the sole and exclusive property of AJP Engineering. This Agreement does 
not grant you any ownership interest or rights in the Software, except for the limited license explicitly granted herein.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
4. Privacy and Data Security
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
Your use of the Software may involve the collection, processing, and storage of certain user data. AJP Engineering handles all data in compliance with its Privacy Policy.
\par For }{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 international users}{\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
, data may be transferred to, stored, and processed in jurisdictions outside of your country of residence (such as the United States or the European Economic Area). By using the Software, you consent to these international data transfers in compliance wit
h applicable data protection laws, including GDPR and CCPA/CPRA where relevant.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
5. Termination
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
This Agreement is effective until terminated. Your rights under this license will terminate automatically without notice from AJP Engineering if you fail to comply with any term(s) of this Agreement. Upon termination, you must cease all use of the Softwar
e and destroy all copies, full or partial, of the Software in your possession.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
6. Disclaimer of Warranties
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
THE SOFTWARE IS PROVIDED TO YOU ""AS IS"" AND ""AS AVAILABLE"" AND WITH ALL FAULTS AND DEFECTS WITHOUT WARRANTY OF ANY KIND. TO THE MAXIMUM EXTENT PERMITTED UNDER APPLICABLE LAW, AJP ENGINEERING EXPRESSLY DISCLAIMS ALL WARRANTIES, WHETHER EXPRESS, IMPLIED, ST
ATUTORY, OR OTHERWISE, INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, TITLE, AND NON-INFRINGEMENT.
\par }{\rtlch\fcs1 \ai\af0 \ltrch\fcs0 \i\f0\kerning0\insrsid4276433\charrsid4276433 
Note for International Users: Some jurisdictions do not allow the exclusion of or limitations on implied warranties, so some or all of the above exclusions and limitations may not apply to you.}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\f0\kerning0\insrsid4276433\charrsid4276433 
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
7. Limitation of Liability
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
TO the maximum extent permitted by applicable law, in no event shall AJP Engineering or its suppliers be liable for any special, incidental, indirect, or consequential damages whatsoever (including, but not limited to, damages for loss of profits, loss of
 data, or business interruption) arising out of or in any way related to the use of or inability to use the Software. In no event shall the total liability of AJP Engineering exceed the actual amount paid by you for the Software.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
8. International Export Control
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
The Software may be subject to domestic and international export control laws, including the United States Export Administration Regulations. You represent and warrant that you are not located in a country that is subject to a government embargo, or that 
has been designated as a ""terrorist supporting"" country, and that you are not listed on any government list of prohibited or restricted parties.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
9. Governing Law and Jurisdiction
\par {\listtext\pard\plain\ltrpar \rtlch\fcs1 \ab\af0 \ltrch\fcs0 \f3\fs20\insrsid4276433\charrsid4276433 \loch\af3\dbch\af0\hich\f3 \'b7\tab}}\pard \ltrpar\ql \fi-360\li720\ri0\sb100\sa100\sbauto1\saauto1\widctlpar
\jclisttab\tx720\wrapdefault\aspalpha\aspnum\faauto\ls2\adjustright\rin0\lin720\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 National Users:}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\f0\kerning0\insrsid4276433\charrsid4276433 
 If you reside or are incorporated within the home jurisdiction of AJP Engineering, this Agreement shall be governed by and construed in accordance with the laws of [Insert State/Province/Country], without regard to its conflict of law principles.
\par {\listtext\pard\plain\ltrpar \rtlch\fcs1 \ab\af0 \ltrch\fcs0 \f3\fs20\insrsid4276433\charrsid4276433 \loch\af3\dbch\af0\hich\f3 \'b7\tab}}{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 International Users:}{\rtlch\fcs1 
\af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
 If you reside outside of the home jurisdiction of AJP Engineering, disputes shall be settled in accordance with the laws of [Insert Preferred Jurisdiction, e.g., the home state of AJP Engineering], and you consent to the personal jurisdiction of the cour
ts located therein. The United Nations Convention on Contracts for the International Sale of Goods is explicitly excluded from this Agreement.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
10. Severability and Entire Agreement
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
If any provision of this Agreement is held to be unenforceable or invalid, such provision will be changed and interpreted to accomplish the objectives of such provision to the greatest extent possible under applicable law, and the remaining provisions wil
l continue in full force and effect. This Agreement constitutes the entire agreement between you and AJP Engineering regarding the Software.
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\outlinelevel2\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \ab\af0\afs27 \ltrch\fcs0 \b\f0\fs27\kerning0\insrsid4276433\charrsid4276433 
11. Contact Information
\par }\pard \ltrpar\ql \li0\ri0\sb100\sa100\sbauto1\saauto1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
If you have any questions about this Agreement, please contact:
\par }{\rtlch\fcs1 \ab\af0 \ltrch\fcs0 \b\f0\kerning0\insrsid4276433\charrsid4276433 AJP Engineering}{\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
\par }\pard \ltrpar\ql \li0\ri0\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid4276433 {\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433 AJPEngineering.com}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\f0\kerning0\insrsid4276433\charrsid4276433 
\par }{\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433 BaseballStatistics@gmail.com}{\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
\par }{\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433 760.500.1163}{\rtlch\fcs1 \af0 \ltrch\fcs0 \f0\kerning0\insrsid4276433\charrsid4276433 
\par }\pard \ltrpar\ql \li0\ri0\sa160\sl278\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 {\rtlch\fcs1 \af31507 \ltrch\fcs0 \insrsid2908686 
\par }{\*\themedata 504b030414000600080000002100e9de0fbfff0000001c020000130000005b436f6e74656e745f54797065735d2e786d6cac91cb4ec3301045f748fc83e52d4a
9cb2400825e982c78ec7a27cc0c8992416c9d8b2a755fbf74cd25442a820166c2cd933f79e3be372bd1f07b5c3989ca74aaff2422b24eb1b475da5df374fd9ad
5689811a183c61a50f98f4babebc2837878049899a52a57be670674cb23d8e90721f90a4d2fa3802cb35762680fd800ecd7551dc18eb899138e3c943d7e503b6
b01d583deee5f99824e290b4ba3f364eac4a430883b3c092d4eca8f946c916422ecab927f52ea42b89a1cd59c254f919b0e85e6535d135a8de20f20b8c12c3b0
0c895fcf6720192de6bf3b9e89ecdbd6596cbcdd8eb28e7c365ecc4ec1ff1460f53fe813d3cc7f5b7f020000ffff0300504b030414000600080000002100a5d6
a7e7c0000000360100000b0000005f72656c732f2e72656c73848fcf6ac3300c87ef85bd83d17d51d2c31825762fa590432fa37d00e1287f68221bdb1bebdb4f
c7060abb0884a4eff7a93dfeae8bf9e194e720169aaa06c3e2433fcb68e1763dbf7f82c985a4a725085b787086a37bdbb55fbc50d1a33ccd311ba548b6309512
0f88d94fbc52ae4264d1c910d24a45db3462247fa791715fd71f989e19e0364cd3f51652d73760ae8fa8c9ffb3c330cc9e4fc17faf2ce545046e37944c69e462
a1a82fe353bd90a865aad41ed0b5b8f9d6fd010000ffff0300504b0304140006000800000021006b799616830000008a0000001c0000007468656d652f746865
6d652f7468656d654d616e616765722e786d6c0ccc4d0ac3201040e17da17790d93763bb284562b2cbaebbf600439c1a41c7a0d29fdbd7e5e38337cedf14d59b
4b0d592c9c070d8a65cd2e88b7f07c2ca71ba8da481cc52c6ce1c715e6e97818c9b48d13df49c873517d23d59085adb5dd20d6b52bd521ef2cdd5eb9246a3d8b
4757e8d3f729e245eb2b260a0238fd010000ffff0300504b030414000600080000002100b5ed5bd9a2040000cb0f0000160000007468656d652f7468656d652f
7468656d65312e786d6ccc57596fe336107e2fd0ff40e85db1ee2388b3902f14688b024d8a3e333a2c6d28c910e9648345fefb0e0fc9a4ed34075260ed1769f4
cdf0e30cf90d79f5e55b4bd04339d0a6efe6967be158a8ecf2be68baeddcfae776632716a20c7705267d57ceada7925a5fae7ffde50a5fb2ba6c4b04fe1dbdc4
73ab666c77399bd11ccc985ef4bbb2836f553fb498c1ebb09d15037e84b82d99798e13cd5adc7416ea700b61ffaaaa262fd12d0f695d8fc1d7045e3b46b92127
c30d0f5d1a1e025bdcbb1c419fe8920ce80193b905e314fde36df98d598860cae0c3dc72c4cf9a5d5fcdf0a57222ec055fcd6f237eca4f3914f79e1873d8de4d
833a6b2f09dc29be0010768a5b27fc3fc513009ce73053c9458fe9869193780aab81e4e399d869ecfa265e8bef9f7076d368e105467c0192f18313bcb349d7ab
d0c00b90c48727f8ccf116a96fe00548e2a3137cb0ce626f6de005a8264d777f8a8ee22489147a82543df9ed2c3c8d22275e29f80105ab615a5d7c88aaef98b1
d6967bcafa16fd8e87b6e9b0c5312dfeda0f1b00f2178259d321f6b42b2b9cc36a1e81b0d2f06589b52f7c6c188d6aa66c6830519c8ca830d6ff31c4212accfb
3055ceab6acd79cb5d29e65b3584dcb02752fe41c594694f9a620346ee27f67c39ed835d0d8f6a46066e3b60e183869efddbb0faa6c63b48972b46d852157a4b
d1aea7b05d85f96c6c3e28d9b77ff685dceeaecbb7b64c2ec5ec6077c2c90e2562121dc5ca080998c20b51d80aa9190970dff790d0063349f86748c4a3f11512
62669fc2223dc322e1e1c752097985d24da9006a5355604321cc9b4218800b38219a635216bc4e5251c7eaf2e28ccf9f52e9979269ac00077a8a5a01874aa79c
eb8bd3e3b3934bed0d95364868cbcd24213223f638ad7151aad5c9ad6fa1f1de5aa787921af4782a542e341a71f25f2c3e5a6bf03bd606d2e94a413af438b722
3f842593e3dddcaa402ee1b1ddc1daa1ddd642986ce1ec91b3416ef88f28cb6ea06c85692d132e4447aa41dbb07240a469e7169ffe5406d2090d11dc5c0f04e1
a7259782acfc6ce4a0e86691cbaa2a73a6975db3f04ccb575078a91567bf0af78f83b967bf8772dfd4c523ba23fbe16f0c4b2c8c5d9ec0a2a10c5a8dcc66d1c0
717012b2c3fa3b922b25bbfa794cac2169c7645763d5517431977021a2131df136e5407b537386846a29518df06ecb1bac9e54a39b4ead4b7278b1ebbeeec433
a789e6a1671aaac2bbe679153346f854e9d7588d29869ead777829ddc7929b8e5a77744e98ba04247ccadfd4efded510346a87c10c6a9cf1a90c73cd5656b377
8c137c85da5b9a84a6fad118f6286f538f383b1c183fd4f9c1ef78d582693a578a4c8b7ba37eb5ebefbe8278ace0f0bc278c8a52c2c56dc07014b9116712291b
b045be31b535e009ed87666e7d77c22c587ae1d27692706d077ee0d84998f9761686bebb0e5d67b5f09ea1b1b0ba75437967dde0b6214feae62aec27b7d7b6c9
879ef615bbc8fb76d68bdbe94c1017b757d77bf9f68a1a109def91b749fd7411d9a99f6dec60b548ec74192dec55b48c579bd5324cd2cdb3851e0438c8fc6510
ad133b72974b3b881c4e3f49ed38f0bc2c88b3641d64cfea18033397f2a17201e915bcae7f000000ffff0300504b0304140006000800000021000dd1909fb600
00001b010000270000007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73848f4d0ac2301484f78277086f6fd3
ba109126dd88d0add40384e4350d363f2451eced0dae2c082e8761be9969bb979dc9136332de3168aa1a083ae995719ac16db8ec8e4052164e89d93b64b06082
8e6f37ed1567914b284d262452282e3198720e274a939cd08a54f980ae38a38f56e422a3a641c8bbd048f7757da0f19b017cc524bd62107bd5001996509affb3
fd381a89672f1f165dfe514173d9850528a2c6cce0239baa4c04ca5bbabac4df000000ffff0300504b01022d0014000600080000002100e9de0fbfff0000001c
0200001300000000000000000000000000000000005b436f6e74656e745f54797065735d2e786d6c504b01022d0014000600080000002100a5d6a7e7c0000000
360100000b00000000000000000000000000300100005f72656c732f2e72656c73504b01022d00140006000800000021006b799616830000008a0000001c0000
0000000000000000000000190200007468656d652f7468656d652f7468656d654d616e616765722e786d6c504b01022d0014000600080000002100b5ed5bd9a2
040000cb0f00001600000000000000000000000000d60200007468656d652f7468656d652f7468656d65312e786d6c504b01022d00140006000800000021000d
d1909fb60000001b0100002700000000000000000000000000ac0700007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73504b050600000000050005005d010000a70800000000}
{\*\colorschememapping 3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d225554462d3822207374616e64616c6f6e653d22796573223f3e0d0a3c613a636c724d
617020786d6c6e733a613d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f64726177696e676d6c2f323030362f6d6169
6e22206267313d226c743122207478313d22646b3122206267323d226c743222207478323d22646b322220616363656e74313d22616363656e74312220616363
656e74323d22616363656e74322220616363656e74333d22616363656e74332220616363656e74343d22616363656e74342220616363656e74353d22616363656e74352220616363656e74363d22616363656e74362220686c696e6b3d22686c696e6b2220666f6c486c696e6b3d22666f6c486c696e6b222f3e}
{\*\latentstyles\lsdstimax376\lsdlockeddef0\lsdsemihiddendef0\lsdunhideuseddef0\lsdqformatdef0\lsdprioritydef99{\lsdlockedexcept \lsdqformat1 \lsdpriority0 \lsdlocked0 Normal;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 1;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 2;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 3;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 4;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 5;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 6;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 7;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 8;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 9;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 1;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 5;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 6;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 7;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 8;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 9;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 1;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 2;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 3;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 4;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 5;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 6;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 7;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 8;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 9;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Normal Indent;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footnote text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 header;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footer;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index heading;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority35 \lsdlocked0 caption;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 table of figures;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 envelope address;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 envelope return;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footnote reference;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation reference;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 line number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 page number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 endnote reference;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 endnote text;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 table of authorities;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 macro;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 toa heading;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 5;\lsdqformat1 \lsdpriority10 \lsdlocked0 Title;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Closing;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Signature;\lsdsemihidden1 \lsdunhideused1 \lsdpriority1 \lsdlocked0 Default Paragraph Font;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 4;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Message Header;\lsdqformat1 \lsdpriority11 \lsdlocked0 Subtitle;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Salutation;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Date;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text First Indent;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text First Indent 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Note Heading;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Block Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Hyperlink;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 FollowedHyperlink;\lsdqformat1 \lsdpriority22 \lsdlocked0 Strong;
\lsdqformat1 \lsdpriority20 \lsdlocked0 Emphasis;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Document Map;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Plain Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 E-mail Signature;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Top of Form;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Bottom of Form;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Normal (Web);\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Acronym;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Address;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Cite;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Code;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Definition;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Keyboard;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Preformatted;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Sample;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Typewriter;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Variable;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Normal Table;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation subject;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 No List;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Simple 1;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Simple 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Simple 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Classic 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Classic 2;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Classic 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Classic 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Colorful 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Colorful 2;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Colorful 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Columns 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Columns 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Columns 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Columns 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Columns 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Grid 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Grid 2;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Grid 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Grid 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Grid 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Grid 6;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Grid 7;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Grid 8;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table List 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table List 2;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table List 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table List 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table List 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table List 6;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table List 7;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table List 8;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table 3D effects 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table 3D effects 2;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table 3D effects 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Contemporary;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Elegant;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Professional;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Subtle 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Subtle 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Web 1;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Web 2;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Web 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Balloon Text;\lsdpriority39 \lsdlocked0 Table Grid;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Table Theme;\lsdsemihidden1 \lsdlocked0 Placeholder Text;
\lsdqformat1 \lsdpriority1 \lsdlocked0 No Spacing;\lsdpriority60 \lsdlocked0 Light Shading;\lsdpriority61 \lsdlocked0 Light List;\lsdpriority62 \lsdlocked0 Light Grid;\lsdpriority63 \lsdlocked0 Medium Shading 1;\lsdpriority64 \lsdlocked0 Medium Shading 2;
\lsdpriority65 \lsdlocked0 Medium List 1;\lsdpriority66 \lsdlocked0 Medium List 2;\lsdpriority67 \lsdlocked0 Medium Grid 1;\lsdpriority68 \lsdlocked0 Medium Grid 2;\lsdpriority69 \lsdlocked0 Medium Grid 3;\lsdpriority70 \lsdlocked0 Dark List;
\lsdpriority71 \lsdlocked0 Colorful Shading;\lsdpriority72 \lsdlocked0 Colorful List;\lsdpriority73 \lsdlocked0 Colorful Grid;\lsdpriority60 \lsdlocked0 Light Shading Accent 1;\lsdpriority61 \lsdlocked0 Light List Accent 1;
\lsdpriority62 \lsdlocked0 Light Grid Accent 1;\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 1;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 1;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 1;\lsdsemihidden1 \lsdlocked0 Revision;
\lsdqformat1 \lsdpriority34 \lsdlocked0 List Paragraph;\lsdqformat1 \lsdpriority29 \lsdlocked0 Quote;\lsdqformat1 \lsdpriority30 \lsdlocked0 Intense Quote;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 1;\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 1;
\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 1;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 1;\lsdpriority70 \lsdlocked0 Dark List Accent 1;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 1;\lsdpriority72 \lsdlocked0 Colorful List Accent 1;
\lsdpriority73 \lsdlocked0 Colorful Grid Accent 1;\lsdpriority60 \lsdlocked0 Light Shading Accent 2;\lsdpriority61 \lsdlocked0 Light List Accent 2;\lsdpriority62 \lsdlocked0 Light Grid Accent 2;\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 2;
\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 2;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 2;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 2;\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 2;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 2;
\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 2;\lsdpriority70 \lsdlocked0 Dark List Accent 2;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 2;\lsdpriority72 \lsdlocked0 Colorful List Accent 2;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 2;
\lsdpriority60 \lsdlocked0 Light Shading Accent 3;\lsdpriority61 \lsdlocked0 Light List Accent 3;\lsdpriority62 \lsdlocked0 Light Grid Accent 3;\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 3;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 3;
\lsdpriority65 \lsdlocked0 Medium List 1 Accent 3;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 3;\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 3;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 3;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 3;
\lsdpriority70 \lsdlocked0 Dark List Accent 3;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 3;\lsdpriority72 \lsdlocked0 Colorful List Accent 3;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 3;\lsdpriority60 \lsdlocked0 Light Shading Accent 4;
\lsdpriority61 \lsdlocked0 Light List Accent 4;\lsdpriority62 \lsdlocked0 Light Grid Accent 4;\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 4;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 4;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 4;
\lsdpriority66 \lsdlocked0 Medium List 2 Accent 4;\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 4;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 4;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 4;\lsdpriority70 \lsdlocked0 Dark List Accent 4;
\lsdpriority71 \lsdlocked0 Colorful Shading Accent 4;\lsdpriority72 \lsdlocked0 Colorful List Accent 4;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 4;\lsdpriority60 \lsdlocked0 Light Shading Accent 5;\lsdpriority61 \lsdlocked0 Light List Accent 5;
\lsdpriority62 \lsdlocked0 Light Grid Accent 5;\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 5;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 5;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 5;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 5;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 5;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 5;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 5;\lsdpriority70 \lsdlocked0 Dark List Accent 5;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 5;
\lsdpriority72 \lsdlocked0 Colorful List Accent 5;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 5;\lsdpriority60 \lsdlocked0 Light Shading Accent 6;\lsdpriority61 \lsdlocked0 Light List Accent 6;\lsdpriority62 \lsdlocked0 Light Grid Accent 6;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 6;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 6;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 6;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 6;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 6;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 6;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 6;\lsdpriority70 \lsdlocked0 Dark List Accent 6;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 6;
\lsdpriority72 \lsdlocked0 Colorful List Accent 6;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 6;\lsdqformat1 \lsdpriority19 \lsdlocked0 Subtle Emphasis;\lsdqformat1 \lsdpriority21 \lsdlocked0 Intense Emphasis;
\lsdqformat1 \lsdpriority31 \lsdlocked0 Subtle Reference;\lsdqformat1 \lsdpriority32 \lsdlocked0 Intense Reference;\lsdqformat1 \lsdpriority33 \lsdlocked0 Book Title;\lsdsemihidden1 \lsdunhideused1 \lsdpriority37 \lsdlocked0 Bibliography;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority39 \lsdlocked0 TOC Heading;\lsdpriority41 \lsdlocked0 Plain Table 1;\lsdpriority42 \lsdlocked0 Plain Table 2;\lsdpriority43 \lsdlocked0 Plain Table 3;\lsdpriority44 \lsdlocked0 Plain Table 4;
\lsdpriority45 \lsdlocked0 Plain Table 5;\lsdpriority40 \lsdlocked0 Grid Table Light;\lsdpriority46 \lsdlocked0 Grid Table 1 Light;\lsdpriority47 \lsdlocked0 Grid Table 2;\lsdpriority48 \lsdlocked0 Grid Table 3;\lsdpriority49 \lsdlocked0 Grid Table 4;
\lsdpriority50 \lsdlocked0 Grid Table 5 Dark;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 1;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 1;
\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 1;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 1;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 1;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 1;
\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 1;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 2;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 2;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 2;
\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 2;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 2;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 2;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 2;
\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 3;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 3;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 3;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 3;
\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 3;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 3;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 3;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 4;
\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 4;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 4;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 4;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 4;
\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 4;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 4;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 5;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 5;
\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 5;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 5;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 5;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 5;
\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 5;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 6;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 6;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 6;
\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 6;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 6;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 6;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 6;
\lsdpriority46 \lsdlocked0 List Table 1 Light;\lsdpriority47 \lsdlocked0 List Table 2;\lsdpriority48 \lsdlocked0 List Table 3;\lsdpriority49 \lsdlocked0 List Table 4;\lsdpriority50 \lsdlocked0 List Table 5 Dark;
\lsdpriority51 \lsdlocked0 List Table 6 Colorful;\lsdpriority52 \lsdlocked0 List Table 7 Colorful;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 1;\lsdpriority47 \lsdlocked0 List Table 2 Accent 1;\lsdpriority48 \lsdlocked0 List Table 3 Accent 1;
\lsdpriority49 \lsdlocked0 List Table 4 Accent 1;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 1;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 1;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 1;
\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 2;\lsdpriority47 \lsdlocked0 List Table 2 Accent 2;\lsdpriority48 \lsdlocked0 List Table 3 Accent 2;\lsdpriority49 \lsdlocked0 List Table 4 Accent 2;
\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 2;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 2;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 2;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 3;
\lsdpriority47 \lsdlocked0 List Table 2 Accent 3;\lsdpriority48 \lsdlocked0 List Table 3 Accent 3;\lsdpriority49 \lsdlocked0 List Table 4 Accent 3;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 3;
\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 3;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 3;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 4;\lsdpriority47 \lsdlocked0 List Table 2 Accent 4;
\lsdpriority48 \lsdlocked0 List Table 3 Accent 4;\lsdpriority49 \lsdlocked0 List Table 4 Accent 4;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 4;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 4;
\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 4;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 5;\lsdpriority47 \lsdlocked0 List Table 2 Accent 5;\lsdpriority48 \lsdlocked0 List Table 3 Accent 5;
\lsdpriority49 \lsdlocked0 List Table 4 Accent 5;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 5;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 5;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 5;
\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 6;\lsdpriority47 \lsdlocked0 List Table 2 Accent 6;\lsdpriority48 \lsdlocked0 List Table 3 Accent 6;\lsdpriority49 \lsdlocked0 List Table 4 Accent 6;
\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 6;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 6;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 6;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Mention;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Smart Hyperlink;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Hashtag;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Unresolved Mention;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Smart Link;}}{\*\datastore 01050000
02000000180000004d73786d6c322e534158584d4c5265616465722e362e3000000000000000000000060000
d0cf11e0a1b11ae1000000000000000000000000000000003e000300feff090006000000000000000000000001000000010000000000000000100000feffffff00000000feffffff0000000000000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
fffffffffffffffffdfffffffeffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffffffffffff0c6ad98892f1d411a65f0040963251e500000000000000000000000030c2
9e8f21eedc01feffffff00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff00000000000000000000000000000000000000000000000000000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff0000000000000000000000000000000000000000000000000000
000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff000000000000000000000000000000000000000000000000
0000000000000000000000000000000000000000000000000105000000000000}}";
            #endregion  // ASSIGN RTF TO RICH TEXT BOX
        }
        #endregion  // FormUserLicenseAgreement_Load
    }
    #endregion  // partial class FormUserLicenseAgreement : Form
}
#endregion  // namespace HenStudio

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
