// For more information see https://aka.ms/fsharp-console-apps
// TypeScript Example
// Define the discriminated union genre
type Genre = 
 |Horror
 |Drama
 |Thriller  
 |Comedy 
 |Fantasy
 |Sport;

// Define the Director record type
type Director = {
  name: string;
  movies: number;
};

// Define the Movie record type
type Movie = {
  name: string;
  runLength: number;
  genre: Genre;
  director: Director;
  imdbRating: number;
};

// Example data
const directors: Director[] = [
  { name: 'Director1', movies: 3 },
  { name: 'Director2', movies: 5 },
  // Add more directors as needed
];

const movies: Movie[] = [
  { name: 'Movie1', runLength: 120, genre: 'Drama', director: directors[0], imdbRating: 8.5 },
  { name: 'Movie2', runLength: 110, genre: 'Comedy', director: directors[1], imdbRating: 7.8 },
  // Add more movies as needed
];

// Filter movies by genre (example: get all Drama movies)
const dramaMovies = movies.filter((movie) => movie.genre === 'Drama');

// Map directors to their total number of movies
const directorMovieCounts = directors.map((director) => ({
  directorName: director.name,
  totalMovies: director.movies,
}));

// Display the results
console.log('Drama Movies:', dramaMovies);
console.log('Director Movie Counts:', directorMovieCounts);




