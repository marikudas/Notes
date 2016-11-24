using AutoMapper;
using Database.Model;
using System.Collections.Generic;


namespace Logic.Mapping
{
    class TypeConvertor 
    {
        public UserMap Convert(User source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<UserMap>(source);
        }

        public NotebookMap Convert(Notebook source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<NotebookMap>(source);
        }

        public NoteMap Convert(Note source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<NoteMap>(source);
        }

        public User Convert(UserMap source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<UserMap, User>();
                cfg.CreateMap<NotebookMap, Notebook>();
                cfg.CreateMap<NoteMap, Note>();
            });
            return Mapper.Map<User>(source);
        }

        public Notebook Convert(NotebookMap source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<UserMap, User>();
                cfg.CreateMap<NotebookMap, Notebook>();
                cfg.CreateMap<NoteMap, Note>();
            });
            return Mapper.Map<Notebook>(source);
        }

        public Note Convert(NoteMap source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<UserMap, User>();
                cfg.CreateMap<NotebookMap, Notebook>();
                cfg.CreateMap<NoteMap, Note>();
            });
            return Mapper.Map<Note>(source);
        }

        public ICollection<UserMap> Convert(ICollection<User> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<ICollection<UserMap>>(source);
        }

        public ICollection<NotebookMap> Convert(ICollection<Notebook> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<ICollection<NotebookMap>>(source);
        }

        public ICollection<NoteMap> Convert(ICollection<Note> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<ICollection<NoteMap>>(source);
        }

        public ICollection<User> Convert(ICollection<UserMap> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<ICollection<User>>(source);
        }

        public ICollection<Notebook> Convert(ICollection<NotebookMap> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<ICollection<Notebook>>(source);
        }

        public ICollection<Note> Convert(ICollection<NoteMap> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>();
                cfg.CreateMap<Notebook, NotebookMap>();
                cfg.CreateMap<Note, NoteMap>();
            });
            return Mapper.Map<ICollection<Note>>(source);
        }
    }

}
