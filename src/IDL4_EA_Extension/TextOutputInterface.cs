/*********************************************************************************************
(c) 2005-2013 Copyright, Real-Time Innovations, Inc.  All rights reserved.    	                             
RTI grants Licensee a license to use, modify, compile, and create derivative works 
of the Software.  Licensee has the right to distribute object form only for use with RTI 
products.  The Software is provided “as is”, with no warranty of any type, including 
any warranty for fitness for any purpose. RTI is under no obligation to maintain or 
support the Software.  RTI shall not be liable for any incidental or consequential 
damages arising out of the use or inability to use the software.
**********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDL4_EA_Extension
{
    public interface TextOutputInterface
    {
        void OutputText(int depth, String text);
        void OutputText(String text);
        void OutputTextLine(int depth, String text);
        void OutputTextLine(String text);
        void OutputTextLine();

        void Clear();
        int GetCurrentPosition();
        void ClearPositionRange(int beginPosition, int endPosition);

        void SaveToFile(String filePath, String[] preambleLines);
    }
}
