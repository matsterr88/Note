using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.IDAL
{
    public interface INoteDal
    {
        public List<Notice> GetNoticeList();

        public Notice GetNotice(int id);

        public bool PostNotice(Notice notice);

        public bool UpdateNotice(Notice notice);

        public bool DeleteNotice(int id);
    }
}
