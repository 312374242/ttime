require 'pathname'
require 'yaml'
require 'singleton'

module TTime
  class Settings
    include Singleton

    SETTINGS_FILE = Pathname.new(ENV['HOME']) + '.ttime.yml'

    attr_accessor :hash

    def initialize
      load_settings
    end

    def load_settings
      if SETTINGS_FILE.exist?
        @hash = SETTINGS_FILE.open { |f| YAML::load(f.read) }
      else
        @hash = {}
      end
    end

    def save
      SETTINGS_FILE.open('w') { |f| f.write YAML::dump(@hash) }
    end

    def selected_courses
      return Array.new if hash['selected_courses'].nil?
      hash['selected_courses']
    end

    def [](*args)
      hash.[](*args)
    end

    def []=(*args)
      hash.[]=(*args)
    end
  end
end
