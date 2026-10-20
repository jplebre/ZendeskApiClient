using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ZendeskApi.Client.Models;
using ZendeskApi.Client.Responses;

namespace ZendeskApi.Client.Resources
{
    public interface ITicketCommentsResource
    {
        [Obsolete("Use `GetAllAsync` instead.")]
        Task<TicketCommentsListResponse> ListAsync(
            long parentId, 
            PagerParameters pager = null,
            CancellationToken cancellationToken = default);

        [Obsolete("Use `GetAllAsync` with CursorPager parameter instead.")]
        Task<TicketCommentsListResponse> GetAllAsync(
            long parentId,
            PagerParameters pager = null,
            CancellationToken cancellationToken = default);

        Task<TicketCommentsListCursorResponse> GetAllAsync(
            long parentId,
            CursorPager pager,
            CancellationToken cancellationToken = default);

        Task AddComment(
            long ticketId, 
            TicketComment ticketComment,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Redacts content from a ticket comment. Redaction is permanent and cannot be undone.
        /// </summary>
        /// <param name="ticketId">The ID of the ticket</param>
        /// <param name="commentId">The ID of the ticket comment</param>
        /// <param name="htmlBody">The comment's html_body containing `&lt;redact&gt;` tags or `redact` attributes</param>
        /// <param name="externalAttachmentUrls">Attachment URLs (content_url) belonging to the comment to be redacted</param>
        Task RedactCommentAsync(
            long ticketId,
            long commentId,
            string htmlBody = null,
            IEnumerable<string> externalAttachmentUrls = null,
            CancellationToken cancellationToken = default);
    }
}