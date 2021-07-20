using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject1_VO;

namespace FinalProject1_Web.Models
{
    public class NoteListViewModel
    {
        public IEnumerable<NoteVO> Notes { get; set; }
        public PagingInfo PageInfo { get; set; }
    }
}