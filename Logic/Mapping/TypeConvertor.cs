using AutoMapper;
using Database.Model;
using System.Collections.Generic;
using Logic.Model;


namespace Logic.Mapping
{
    public class TypeConvertor 
    {
        public UserMap Convert(User source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>().MaxDepth(1);
                cfg.CreateMap<Notebook, NotebookMap>().MaxDepth(1);
                cfg.CreateMap<Note, NoteMap>().MaxDepth(1);
            });
            return Mapper.Map<UserMap>(source);
        }

        public NotebookMap Convert(Notebook source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>().MaxDepth(1);
                cfg.CreateMap<Notebook, NotebookMap>().MaxDepth(1);
                cfg.CreateMap<Note, NoteMap>().MaxDepth(1);
            });
            return Mapper.Map<NotebookMap>(source);
        }

        public NoteMap Convert(Note source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>().MaxDepth(1);
                cfg.CreateMap<Notebook, NotebookMap>().MaxDepth(1);
                cfg.CreateMap<Note, NoteMap>().MaxDepth(1);
            });
            return Mapper.Map<NoteMap>(source);
        }

        public User Convert(UserMap source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<UserMap, User>().MaxDepth(1);
                cfg.CreateMap<NotebookMap, Notebook>().MaxDepth(1);
                cfg.CreateMap<NoteMap, Note>().MaxDepth(1);
            });
            return Mapper.Map<User>(source);
        }

        public Notebook Convert(NotebookMap source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<UserMap, User>().MaxDepth(1);
                cfg.CreateMap<NotebookMap, Notebook>().MaxDepth(1);
                cfg.CreateMap<NoteMap, Note>().MaxDepth(1);
            });
            return Mapper.Map<Notebook>(source);
        }

        public Note Convert(NoteMap source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<UserMap, User>().MaxDepth(1);
                cfg.CreateMap<NotebookMap, Notebook>().MaxDepth(1);
                cfg.CreateMap<NoteMap, Note>().MaxDepth(1);
            });
            return Mapper.Map<Note>(source);
        }

        public ICollection<UserMap> Convert(ICollection<User> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>().MaxDepth(1);
                cfg.CreateMap<Notebook, NotebookMap>().MaxDepth(1);
                cfg.CreateMap<Note, NoteMap>().MaxDepth(1);
            });
            return Mapper.Map<ICollection<UserMap>>(source);
        }

        public ICollection<NotebookMap> Convert(ICollection<Notebook> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>().MaxDepth(1);
                cfg.CreateMap<Notebook, NotebookMap>().MaxDepth(1);
                cfg.CreateMap<Note, NoteMap>().MaxDepth(1);
            });
            return Mapper.Map<ICollection<NotebookMap>>(source);
        }

        public ICollection<NoteMap> Convert(ICollection<Note> source)
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserMap>().MaxDepth(1);
                cfg.CreateMap<Notebook, NotebookMap>().MaxDepth(1);
                cfg.CreateMap<Note, NoteMap>().MaxDepth(1);
            });
            return Mapper.Map<ICollection<NoteMap>>(source);
        }


    }

}
