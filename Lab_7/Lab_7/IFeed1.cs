using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;

namespace Lab_7
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFeed1" in both code and config file together.
    [ServiceContract]
    [ServiceKnownType(typeof(Atom10FeedFormatter))]
    [ServiceKnownType(typeof(Rss20FeedFormatter))]
    [ServiceKnownType(typeof(List<Note>))]
    public interface IFeed1
    {

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/{studentId}")]
        SyndicationFeedFormatter GetStudentNotes(string studentId);

        // TODO: Add your service operations here
    }
}
