/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Message configuration for a campaign.
    /// </summary>
    public partial class MessageConfiguration
    {
        private Message _admMessage;
        private Message _apnsMessage;
        private Message _baiduMessage;
        private Message _defaultMessage;
        private CampaignEmailMessage _emailMessage;
        private Message _gcmMessage;
        private CampaignSmsMessage _smsMessage;

        /// <summary>
        /// Gets and sets the property ADMMessage. The message that the campaign delivers to ADM
        /// channels. Overrides the default message.
        /// </summary>
        public Message ADMMessage
        {
            get { return this._admMessage; }
            set { this._admMessage = value; }
        }

        // Check to see if ADMMessage property is set
        internal bool IsSetADMMessage()
        {
            return this._admMessage != null;
        }

        /// <summary>
        /// Gets and sets the property APNSMessage. The message that the campaign delivers to
        /// APNS channels. Overrides the default message.
        /// </summary>
        public Message APNSMessage
        {
            get { return this._apnsMessage; }
            set { this._apnsMessage = value; }
        }

        // Check to see if APNSMessage property is set
        internal bool IsSetAPNSMessage()
        {
            return this._apnsMessage != null;
        }

        /// <summary>
        /// Gets and sets the property BaiduMessage. The message that the campaign delivers to
        /// Baidu channels. Overrides the default message.
        /// </summary>
        public Message BaiduMessage
        {
            get { return this._baiduMessage; }
            set { this._baiduMessage = value; }
        }

        // Check to see if BaiduMessage property is set
        internal bool IsSetBaiduMessage()
        {
            return this._baiduMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultMessage. The default message for all channels.
        /// </summary>
        public Message DefaultMessage
        {
            get { return this._defaultMessage; }
            set { this._defaultMessage = value; }
        }

        // Check to see if DefaultMessage property is set
        internal bool IsSetDefaultMessage()
        {
            return this._defaultMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EmailMessage. The email message configuration.
        /// </summary>
        public CampaignEmailMessage EmailMessage
        {
            get { return this._emailMessage; }
            set { this._emailMessage = value; }
        }

        // Check to see if EmailMessage property is set
        internal bool IsSetEmailMessage()
        {
            return this._emailMessage != null;
        }

        /// <summary>
        /// Gets and sets the property GCMMessage. The message that the campaign delivers to GCM
        /// channels. Overrides the default message.
        /// </summary>
        public Message GCMMessage
        {
            get { return this._gcmMessage; }
            set { this._gcmMessage = value; }
        }

        // Check to see if GCMMessage property is set
        internal bool IsSetGCMMessage()
        {
            return this._gcmMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SMSMessage. The SMS message configuration.
        /// </summary>
        public CampaignSmsMessage SMSMessage
        {
            get { return this._smsMessage; }
            set { this._smsMessage = value; }
        }

        // Check to see if SMSMessage property is set
        internal bool IsSetSMSMessage()
        {
            return this._smsMessage != null;
        }

    }
}