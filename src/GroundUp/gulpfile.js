﻿var gulp = require('gulp');
var uglify = require('gulp-uglify');

gulp.task('minify', function () {
    return gulp.src("wwwroot/js/*.js")
});