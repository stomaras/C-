import {IActor,IDirector,IGenre,IMovie} from './hollywoodModels'

let m1:IMovie = {
    title: 'Titanic',
    photoUrl: 'https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_FMjpg_UY720_.jpg',
    productionDate: new Date(1998,4,3),
    rating: 7.8,
    price: 18,
    duration: 170,
    director: {firstName:"James Cameron", lastName:"Cameron"},
    actors: [
        {firstName:"Leonardo",lastName:"Di Caprio"},
        {firstName:"Kate",lastName:"Winslet"},
        {firstName:"Leonardo",lastName:"Di Caprio"},
    ],
    genres: [
        {kind:"Drama"},{kind:"Romance"}
    ]
}

let m2:IMovie = {
    title: 'Inception',
    photoUrl: 'https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UX700_.jpg',
    productionDate: new Date(2010,6,5),
    rating: 8.6,
    price: 23,
    duration: 220,
    director: {firstName:"James", lastName:"Cameron"},
    actors: [
        {firstName:"Leonardo",lastName:"Di Caprio"},
        {firstName:"Ellen",lastName:"Page"}
    ],
    genres: [{kind:"Action"},{kind:"Adventure"},{kind:"Sci-fi"}]
}

let m3:IMovie = {
    title: 'Avatar',
    photoUrl: 'https://m.media-amazon.com/images/M/MV5BMTYwOTEwNjAzMl5BMl5BanBnXkFtZTcwODc5MTUwMw@@._V1_FMjpg_UX510_.jpg',
    productionDate: new Date(2009,6,5),
    rating: 8.8,
    price: 25,
    duration: 240,
    director: {firstName:"James", lastName:"Cameron"},
    actors: [
        {firstName:"Sam",lastName:"Worthington"},
        {firstName:"Zoe",lastName:"Saldana"},
    ],
    genres: [
        {kind:"Action"},{kind:"Adventure"},{kind:"Fantasy"}
    ]
}


export let movies: Array<IMovie> = [m1,m2,m3];

