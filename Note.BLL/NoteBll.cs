using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.BLL
{
    public class NoteBll
    {
        private readonly INoteDal _noteDal;

        public NoteBll(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        public bool DeleteNotice(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException();
            }            

            return _noteDal.DeleteNotice(id);
        }

        public Notice GetNotice(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException();
            }
            return _noteDal.GetNotice(id);
        }

        public List<Notice> GetNoticeList()
        {
            return _noteDal.GetNoticeList();
        }

        public bool PostNotice(Notice notice)
        {
            if(notice == null)
            {
                throw new ArgumentException();
            }
            return _noteDal.PostNotice(notice);
        }

        public bool UpdateNotice(Notice notice)
        {
            if(notice == null)
            {
                throw new ArgumentException();
            }
            return _noteDal.UpdateNotice(notice);
        }
    }
}
