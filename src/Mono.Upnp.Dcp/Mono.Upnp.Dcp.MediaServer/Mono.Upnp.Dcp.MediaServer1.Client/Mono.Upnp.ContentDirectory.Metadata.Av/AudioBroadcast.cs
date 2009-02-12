// 
// AudioBroadcast.cs
//  
// Author:
//       Scott Peterson <lunchtimemama@gmail.com>
// 
// Copyright (c) 2009 Scott Peterson
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Xml;

namespace Mono.Upnp.ContentDirectory.Metadata.Av
{
	public class AudioBroadcast  : AudioItem
	{
		protected AudioBroadcast ()
		{
		}
		
        public string Region { get; private set; }
        public string RadioCallSign { get; private set; }
        public string RadioStationId { get; private set; }
        public string RadioBand { get; private set; }
        public int? ChannelNr { get; private set; } // FIXME is this right?
		
		protected override void DeserializePropertyElement (XmlReader reader)
		{
			if (reader == null) throw new ArgumentNullException ("reader");
			
			if (reader.NamespaceURI == Schemas.UpnpSchema) {
				switch (reader.Name) {
				case "region":
					Region = reader.ReadString ();
				 	break;
				case "radioCallSign":
					RadioCallSign = reader.ReadString ();
					break;
				case "radioStationID":
					RadioStationId = reader.ReadString ();
					break;
				case "radioBand":
					RadioBand = reader.ReadString ();
					break;
				case "channelNr":
					ChannelNr = reader.ReadContentAsInt ();
					break;
				default:
					base.DeserializePropertyElement (reader);
					break;
				}
			} else {
				base.DeserializePropertyElement (reader);
			}
		}
	}
}