﻿/*
DataMatrix.Net

DataMatrix.Net - .net library for decoding DataMatrix codes.
Copyright (C) 2009/2010 Michael Faschinger

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public
License as published by the Free Software Foundation; either
version 3.0 of the License, or (at your option) any later version.
You can also redistribute and/or modify it under the terms of the
GNU Lesser General Public License as published by the Free Software
Foundation; either version 3.0 of the License or (at your option)
any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
General Public License or the GNU Lesser General Public License
for more details.

You should have received a copy of the GNU General Public
License and the GNU Lesser General Public License along with this
library; if not, write to the Free Software Foundation, Inc.,
51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA

Contact: Michael Faschinger - michfasch@gmx.at

*/

namespace DataMatrix.NetCore
{
    internal struct DmtxBestLine
    {
        internal int Angle { get; set; }

        internal int HOffset { get; set; }

        internal int Mag { get; set; }

        internal int StepBeg { get; set; }

        internal int StepPos { get; set; }

        internal int StepNeg { get; set; }

        internal int DistSq { get; set; }

        internal double Devn { get; set; }

        internal DmtxPixelLoc LocBeg { get; set; }

        internal DmtxPixelLoc LocPos { get; set; }

        internal DmtxPixelLoc LocNeg { get; set; }
    }
}
