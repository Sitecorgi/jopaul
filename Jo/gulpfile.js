var gulp = require('gulp'),
    sass = require('gulp-sass')
    cssmin = require("gulp-cssmin")
    rename = require("gulp-rename");

const { watch } = require('gulp');

gulp.task('min:css', function () {
    return gulp.src('assets/scss/style.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(cssmin())
        .pipe(rename({
            suffix: ".min"
        }))
        .pipe(gulp.dest('wwwroot/css'));
    });

gulp.task('img',
    function() {
        return gulp.src('assets/img/*')
            .pipe(gulp.dest('wwwroot/img'));
    });

gulp.task('watch:css', function() {
    watch(['./assets/scss/*.scss', './assets/scss/partials/*.scss'], gulp.series('min:css'));
});