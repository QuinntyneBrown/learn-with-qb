"use strict";

var gulp = require("gulp");
var concat = require('gulp-concat');
var templateCache = require('gulp-angular-templatecache');

gulp.task('concat-js', function () {
    return gulp.src(["wwwroot/**/*.js"])
      .pipe(concat('app.js'))
      .pipe(gulp.dest('./dist/'));
});

gulp.task('watch', ['concat-js'], function () {
    gulp.watch(["wwwroot/**/*.js"], ['template-cache', 'concat-js']);
});

gulp.task('template-cache', function () {
    return gulp.src('wwwroot/**/*.html')
        .pipe(templateCache({
            standalone: true
        }))
        .pipe(concat('templates.js'))
        .pipe(gulp.dest('./dist/'));
});

gulp.task('default', ['template-cache', 'concat-js', 'watch']);