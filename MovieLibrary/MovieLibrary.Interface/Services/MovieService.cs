﻿using AutoMapper;
using MovieLibrary.Core.ModelsDTO;
using MovieLibrary.Core.Repositories;
using MovieLibrary.Infrastructure.Mappers;
using MovieLibrary.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _repository { get; set; }
        private IMapper _mapper { get; set; }

        public MovieService(IMovieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IQueryable<Movie> GetAllMovies()
        {
            var MoviesDto = _repository.GetAll();
            var Movies = MoviesDto.Select( x => _mapper.Map<Movie>( x ) );
            
            return Movies;
        }

        public Movie GetMovie(Guid id)
        {
            var SelectedMovieEntity = _repository.GetById(id);
            var SelectedMovie = _mapper.Map<Movie>(SelectedMovieEntity);
            return SelectedMovie;
        }

        public void Create(Movie movie)
        {
            var MovieEntity = _mapper.Map<MovieEntity>(movie);
            _repository.Create(MovieEntity);
        }

        public void Update(Movie movie)
        {
            var MovieEntity = _mapper.Map<MovieEntity>(movie);
            _repository.Update(MovieEntity);
        }
    }
}
